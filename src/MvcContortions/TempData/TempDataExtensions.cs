using System.Web.Mvc;
using System.Web.Routing;

namespace MvcContortions
{
    public static class TempDataExtensions
    {
        public static RedirectToRouteResult WithTempData(this RedirectToRouteResult result, TempDataDictionary tempData, object tempDataValues)
        {
            var valueDictionary = new RouteValueDictionary(tempDataValues);
            foreach (var item in valueDictionary)
            {
                tempData[item.Key] = item.Value;
            }
            return result;
        }
    }
}
