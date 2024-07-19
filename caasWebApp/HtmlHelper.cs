using Microsoft.AspNetCore.Mvc.Rendering;

namespace caasWebApp
{
    public static class HtmlHelper
    {
        public static string ActiveClass(this IHtmlHelper htmlHelper, string route)
        {
            var routeData = htmlHelper.ViewContext.RouteData;

            var pageRoute = routeData.Values["page"].ToString();

            return route == pageRoute ? "active" : "";
        }
    }
}
