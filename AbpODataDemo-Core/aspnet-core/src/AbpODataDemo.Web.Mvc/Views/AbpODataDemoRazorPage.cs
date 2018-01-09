using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpODataDemo.Web.Views
{
    public abstract class AbpODataDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpODataDemoRazorPage()
        {
            LocalizationSourceName = AbpODataDemoConsts.LocalizationSourceName;
        }
    }
}
