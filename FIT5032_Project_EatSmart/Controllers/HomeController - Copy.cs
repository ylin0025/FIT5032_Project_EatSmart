using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Project_EatSmart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Diary()
        {
            ViewBag.Message = "Your diary page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Your forum page.";

            return View();
        }

        public ActionResult Nutrition()
        {
            ViewBag.Message = "Your nutrition page.";

            return View();
        }

        public ActionResult NutritionCalculator()
        {
            ViewBag.Message = "Your calculator page.";

            return View();
        }
    }
}