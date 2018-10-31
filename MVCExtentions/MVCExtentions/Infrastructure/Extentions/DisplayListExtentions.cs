using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCExtentions.Infrastructure.Extentions
{
    public static class DisplayListExtentions
    {
        public static MvcHtmlString DisplayList(this HtmlHelper helper, List<string> data)
        {
            var ulBuilder = new TagBuilder("ul");
            foreach (var item in data)
            {
                var liBuilder = new TagBuilder("li");
                liBuilder.SetInnerText(item);
                liBuilder.InnerHtml += liBuilder.ToString();
            }
            return new MvcHtmlString(ulBuilder.ToString());
        }
    }
}