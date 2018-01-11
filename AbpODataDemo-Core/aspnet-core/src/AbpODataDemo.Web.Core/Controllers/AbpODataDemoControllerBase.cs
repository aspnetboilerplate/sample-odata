using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpODataDemo.Controllers
{
    public abstract class AbpODataDemoControllerBase: AbpController
    {
        protected AbpODataDemoControllerBase()
        {
            LocalizationSourceName = AbpODataDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
