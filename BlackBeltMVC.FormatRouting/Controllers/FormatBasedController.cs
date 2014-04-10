using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackBeltMVC.FormatRouting.Controllers
{
    public class FormatBasedController : Controller
    {
        protected override IActionInvoker CreateActionInvoker()
        {
            return new FormatBasedActionInvoker();
        }

        public class FormatBasedActionInvoker : ControllerActionInvoker
        {
            protected override ActionResult CreateActionResult(
                ControllerContext controllerContext,
                ActionDescriptor actionDescriptor,
                object actionReturnValue)
            {
                var format = controllerContext.RouteData.Values["format"] as string;

                controllerContext.Controller.ViewData.Model = actionReturnValue;
                switch (format)
                {
                    case "html":
                        return new ViewResult
                        {
                            ViewData = controllerContext.Controller.ViewData
                        };
                    case "json":
                        return new JsonResult
                        {
                            Data = actionReturnValue,
                            JsonRequestBehavior = JsonRequestBehavior.AllowGet
                        };
                }

                return base.CreateActionResult(
                    controllerContext,
                    actionDescriptor,
                    actionReturnValue);
            }
        }
    }
}
