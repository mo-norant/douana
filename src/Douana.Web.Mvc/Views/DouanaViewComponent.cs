using Abp.AspNetCore.Mvc.ViewComponents;

namespace Douana.Web.Views
{
    public abstract class DouanaViewComponent : AbpViewComponent
    {
        protected DouanaViewComponent()
        {
            LocalizationSourceName = DouanaConsts.LocalizationSourceName;
        }
    }
}
