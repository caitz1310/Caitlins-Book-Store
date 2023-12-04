using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FA2_Caitlin_Hermanus_20232198.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Favorites()
        {
            ViewBag.Message = "Your Favorties page.";

            return View();
        }

        public ActionResult Latest()
        {
            ViewBag.Message = "Your Latest page.";

            return View();
        }
       

        public ActionResult Location()
        {
            ViewBag.Message = "Your Location page.";

            return View();
        }
    }
}