using System;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace MVCExtentions.Infrastructure.Extentions.ModelBinder
{
    public class XMLModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {

            try
            {
                var _modelType = bindingContext.ModelType;
                var _serializer = new XmlSerializer(_modelType);

                var inputStream = controllerContext.HttpContext.Request.InputStream;
                return _serializer.Deserialize(inputStream);

            }
            catch (Exception ex)
            {
                bindingContext.ModelState.AddModelError("", "The item could not be serialized");
                return null;
            }
        }
    }
}