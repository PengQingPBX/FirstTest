using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Json.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult JsonTest()
        {
            return View();
        }
        public ActionResult JsonTest(int a=0)
        {
            return Json(new { name="脾气"});
        }
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
    }
}