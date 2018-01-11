using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpODataDemo.Web.Views
{
    public abstract class AbpODataDemoViewComponent : AbpViewComponent
    {
        protected AbpODataDemoViewComponent()
        {
            LocalizationSourceName = AbpODataDemoConsts.LocalizationSourceName;
        }
    }
}
