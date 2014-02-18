using BlackBeltMVC.Filters;
using System.Web;
using System.Web.Mvc;

namespace BlackBeltMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            FilterProviders.Providers.Add(new FilterProvider());
        }
    }
}
