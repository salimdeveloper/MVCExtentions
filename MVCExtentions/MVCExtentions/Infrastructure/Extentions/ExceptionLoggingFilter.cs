using System.Web.Mvc;

namespace MVCExtentions.Infrastructure.Extentions
{
    public class ExceptionLoggingFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //send ajax response
            if (filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                filterContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new
                    {
                        Message = "An error has occured. Please try again later",
                    }
                };
            }
            filterContext.HttpContext.Response.StatusCode = 500;
            filterContext.ExceptionHandled = true;

        }

    }
}