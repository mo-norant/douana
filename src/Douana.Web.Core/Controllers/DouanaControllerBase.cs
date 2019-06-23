using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Douana.Controllers
{
    public abstract class DouanaControllerBase: AbpController
    {
        protected DouanaControllerBase()
        {
            LocalizationSourceName = DouanaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
