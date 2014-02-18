using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackBeltMVC.Filters
{
    public class FilterProvider : IFilterProvider
    {
        public IEnumerable<Filter> GetFilters(
            ControllerContext controllerContext, 
            ActionDescriptor actionDescriptor)
        {
            return new List<Filter>
            {
                new Filter(new MyAwesomeFilter(), FilterScope.Action, 0)
            };
        }
    }

    public class MyAwesomeFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var i = 0;
            i += 1;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var i = 0;
            i += 1;
        }
    }
}