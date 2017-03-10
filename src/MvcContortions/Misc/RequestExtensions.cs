using System.Web;
using System.Web.Routing;

namespace MvcContortions
{
    public static class RequestExtensions
    {
        public static string GetController(this HttpRequestBase request) => request.RequestContext.GetController();
        public static string GetAction(this HttpRequestBase request) => request.RequestContext.GetAction();
        public static string GetArea(this HttpRequestBase request) => request.RequestContext.GetArea();

        public static string GetController(this HttpRequest request) => request.RequestContext.GetController();
        public static string GetAction(this HttpRequest request) => request.RequestContext.GetAction();
        public static string GetArea(this HttpRequest request) => request.RequestContext.GetArea();

        private static string GetController(this RequestContext context) => context.GetValue("controller");
        private static string GetAction(this RequestContext context) => context.GetValue("action");
        private static string GetArea(this RequestContext context) => context.GetValue("area");
        private static string GetValue(this RequestContext context, string key) => context.RouteData.Values[key]?.ToString();
    }
}
