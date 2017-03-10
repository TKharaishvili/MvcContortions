using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcContortions
{
    public static class ExtensionMethods
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


        public static SelectList ToSelectList(this IEnumerable items) => new SelectList(items);
        
        public static SelectList ToSelectList<TModel, TValue, TText>(this IEnumerable<TModel> items, Expression<Func<TModel, TValue>> valueExpr, Expression<Func<TModel, TText>> textExpr) =>
            new SelectList(items, ExpressionHelper.GetExpressionText(valueExpr), ExpressionHelper.GetExpressionText(textExpr));
    }
}
