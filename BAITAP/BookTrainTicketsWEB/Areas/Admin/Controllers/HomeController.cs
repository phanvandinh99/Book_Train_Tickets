using BookTrainTicketsWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookTrainTicketsWEB.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        EFQuanLyDatVe db = new EFQuanLyDatVe();

        public ActionResult Index()
        {
            ViewBag.GaDen_Di = db.NhaGa.ToList();
            return View();
        }
    }
}