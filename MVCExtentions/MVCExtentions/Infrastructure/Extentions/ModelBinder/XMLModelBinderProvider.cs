using System;
using System.Web;
using System.Web.Mvc;

namespace MVCExtentions.Infrastructure.Extentions.ModelBinder
{
    public class XMLModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(Type modelType)
        {
            var _contentType = HttpContext.Current.Request.ContentType.ToLower();
            if (_contentType != "text/xml")
            {
                return null;
            }
            return new XMLModelBinder();
        }
    }
}