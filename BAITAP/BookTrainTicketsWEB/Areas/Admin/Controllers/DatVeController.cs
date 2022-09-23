using BookTrainTicketsWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookTrainTicketsWEB.Areas.Admin.Controllers
{
    public class DatVeController : Controller
    {
        EFQuanLyDatVe db = new EFQuanLyDatVe();

        public ActionResult ChoNgoi()
        {
            return View();
        }
    }
}