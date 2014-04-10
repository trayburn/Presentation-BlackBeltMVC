using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackBeltMVC.FormatRouting.Models;

namespace BlackBeltMVC.FormatRouting.Controllers
{
    public class HomeController : FormatBasedController
    {
        public object Index()
        {
            return new HomeViewModel { Message = "This is your message" };
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