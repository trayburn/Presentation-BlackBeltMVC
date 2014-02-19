using Highway.BlackBeltMVC.App_Architecture.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Highway.BlackBeltMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInjectableFilter[] filters;
        public HomeController(IInjectableFilter[] filters)
        {
            this.filters = filters;
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