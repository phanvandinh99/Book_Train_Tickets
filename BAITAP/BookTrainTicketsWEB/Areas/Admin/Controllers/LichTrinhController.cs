using BookTrainTicketsWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace BookTrainTicketsWEB.Areas.Admin.Controllers
{
    public class LichTrinhController : Controller
    {
        EFQuanLyDatVe db = new EFQuanLyDatVe();

        [HttpPost]
        public ActionResult LichTrinh(int iGaDi, int iGaDen, string sNgayDi, string sNgayVe)
        {
            // trường hợp ngày về = null => không phải vé khứ hồi
            if (string.IsNullOrEmpty(sNgayVe.ToString()))
            {
                var listLichTrinh = db.LichTrinh.Where(n => n.MaNhaGa == iGaDi &&
                                                            n.GaDen == iGaDen &&
                                                            n.NgayDi.Year == sNgayVe.Year &&
                                                            n.NgayDi.Month == sNgayVe.Month &&
                                                            n.NgayDi.Date == sNgayVe.Date).ToList();
                return View(listLichTrinh);
            }
            else // Trường hợp muốn tìm vé khứ hồi
            {
                var listLichTrinh = db.LichTrinh.Where(n => n.MaNhaGa == iGaDen &&
                                                           n.GaDen == iGaDi &&
                                                           n.NgayDi.ToString("yyyyMMdd").Equals(Convert.ToDateTime(sNgayVe).ToString("yyyyMMdd"))).ToList();
                return View(listLichTrinh);
            }
        }
    }
}