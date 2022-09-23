using BookTrainTicketsWEB.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BookTrainTicketsWEB.Areas.Admin.Controllers
{
    public class LichTrinhController : Controller
    {
        EFQuanLyDatVe db = new EFQuanLyDatVe();

        [HttpPost]
        public ActionResult LichTrinh(int iGaDi, string sGaDen, string sNgayDi, string sNgayVe)
        {
            
            // trường hợp ngày về = null => không phải vé khứ hồi
            if (string.IsNullOrEmpty(sNgayVe.ToString()))
            {
                // Ép kiểu string thành kiểu datetime
                DateTime dNgayDi = DateTime.Parse(sNgayDi);

                ViewBag.ListLichTrinhDi = db.LichTrinh.Where(n => n.MaNhaGa == iGaDi &&
                                                            n.GaDen.Equals(sGaDen) &&
                                                            n.NgayDi.Year == dNgayDi.Year &&
                                                            n.NgayDi.Month == dNgayDi.Month &&
                                                            n.NgayDi.Day == dNgayDi.Day).ToList();

                ViewBag.LichTrinhKhuHoi = 0;
            }
            else // Trường hợp muốn tìm vé đi và cả vé khứ hồi
            {
                // Ép kiểu string thành kiểu datetime
                DateTime dNgayVe = DateTime.Parse(sNgayVe);
                DateTime dNgayDi = DateTime.Parse(sNgayDi);

                // Tìm mã ga đến theo tên
                int iMaNhaGa = db.NhaGa.Where(n => n.TenNhaGa.Equals(sGaDen)).Select(n => n.MaNhaGa).FirstOrDefault();

                // Tìm tên ga đi theo tên
                string sTenNhaGa = db.NhaGa.Where(n => n.MaNhaGa == iGaDi).Select(n => n.TenNhaGa).FirstOrDefault();

                ViewBag.ListLichTrinhDi = db.LichTrinh.Where(n => n.MaNhaGa == iGaDi &&
                                                             n.GaDen.Equals(sGaDen) &&
                                                             n.NgayDi.Year == dNgayDi.Year &&
                                                             n.NgayDi.Month == dNgayDi.Month &&
                                                             n.NgayDi.Day == dNgayDi.Day).ToList();


                ViewBag.LichTrinhKhuHoi = db.LichTrinh.Where(n => n.MaNhaGa == iMaNhaGa &&
                                                            n.GaDen.Equals(sTenNhaGa) &&
                                                            n.NgayDi.Year == dNgayVe.Year &&
                                                            n.NgayDi.Month == dNgayVe.Month &&
                                                            n.NgayDi.Day == dNgayVe.Day).ToList();
            }
            return View();
        }
    }
}