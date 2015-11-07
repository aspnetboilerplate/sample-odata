using Abp.Application.Services;

namespace AbpODataDemo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AbpODataDemoAppServiceBase : ApplicationService
    {
        protected AbpODataDemoAppServiceBase()
        {
            LocalizationSourceName = AbpODataDemoConsts.LocalizationSourceName;
        }
    }
}