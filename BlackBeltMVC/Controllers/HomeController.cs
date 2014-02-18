using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackBeltMVC.Controllers
{
    public class HomeController : Controller
    {
        //public object Index(HomeViewModel model, CurrentUser user)
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View(new HomeViewModel
            {
                //Message = "I am a Black Belt!"
                Message = string.Format("{0} is a Black Belt!", HttpContext.Request.Browser.Id)
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
            if (this.Binders.ContainsKey(typeof(CurrentUser)) == false)
                this.Binders.Add(typeof(CurrentUser), new CurrentUserModelBinder());
        }

        protected override ActionResult CreateActionResult(
            ControllerContext controllerContext,
            ActionDescriptor actionDescriptor,
            object actionReturnValue)
        {

            if (actionReturnValue == null)
                actionReturnValue = new HomeViewModel() { Message = "Hello guys!" };
            controllerContext.Controller.ViewData.Model = actionReturnValue;
            return new ViewResult
            {
                ViewData = controllerContext.Controller.ViewData
            };
        }
    }








    public class CurrentUser
    {
        public string User { get; set; }
    }











    public class CurrentUserModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, 
            ModelBindingContext bindingContext)
        {
            return new CurrentUser { 
                User = controllerContext.HttpContext.Request.Browser.Id 
            };
        }
    }

}
