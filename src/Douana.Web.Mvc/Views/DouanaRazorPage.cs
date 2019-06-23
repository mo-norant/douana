using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Douana.Web.Views
{
    public abstract class DouanaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DouanaRazorPage()
        {
            LocalizationSourceName = DouanaConsts.LocalizationSourceName;
        }
    }
}
