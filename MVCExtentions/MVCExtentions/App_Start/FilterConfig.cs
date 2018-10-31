using MVCExtentions.Infrastructure.Extentions;
using System.Web.Mvc;

namespace MVCExtentions.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ExceptionLoggingFilter());
        }
    }
}