using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KrantzMIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A little bit about Cameron.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Cameron's contact info.";

            return View();
        }
    }
}