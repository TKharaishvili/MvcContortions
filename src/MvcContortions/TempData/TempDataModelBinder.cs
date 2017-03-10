using System.Web.Mvc;

namespace MvcContortions
{
    public sealed class TempDataModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) =>
            controllerContext.Controller.TempData.TryGetValue(bindingContext.ModelName, out var value) ? value : null;
    }
}
