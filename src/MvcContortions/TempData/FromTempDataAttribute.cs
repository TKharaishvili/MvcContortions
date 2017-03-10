using System;
using System.Web.Mvc;

namespace MvcContortions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public sealed class FromTempDataAttribute : CustomModelBinderAttribute
    {
        static TempDataModelBinder _binder = new TempDataModelBinder();
        public override IModelBinder GetBinder() => _binder;
    }
}
