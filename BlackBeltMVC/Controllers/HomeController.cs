using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackBeltMVC.Controllers
{
    public class HomeController : Controller
    {
        public object Index(CurrentUser user)
        {
            ViewBag.Title = "Home Page";

            return View(new HomeViewModel
            {
                Message = "I am a Black Belt!"
                //Message = string.Format("{0} is a Black Belt!", user.UserName)
            });
        }

        //protected override IActionInvoker CreateActionInvoker()
        //{
        //    return new ViewResultControllerActionInvoker();
        //}
    }

    public class HomeViewModel
    {
        public string Message { get; set; }
    }

    public class ViewResultControllerActionInvoker : ControllerActionInvoker
    {
        public ViewResultControllerActionInvoker() : base()
        {
            Binders.Add(typeof(CurrentUser), new CurrentUserModelBinder());
        }
    }


    public class CurrentUser
    {
        public string UserName { get; set; }
    }


    public class CurrentUserModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, 
            ModelBindingContext bindingContext)
        {
            return new CurrentUser { 
                UserName = controllerContext.HttpContext.Request.Browser.Id 
            };
        }
    }

}
