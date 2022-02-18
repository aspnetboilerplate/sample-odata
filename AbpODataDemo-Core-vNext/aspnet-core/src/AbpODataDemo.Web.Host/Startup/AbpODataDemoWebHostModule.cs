using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.AspNetCore.OData.ResultWrapping;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpODataDemo.Configuration;

namespace AbpODataDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpODataDemoWebCoreModule))]
    public class AbpODataDemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpODataDemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().WrapResultFilters.Add(new AbpODataDontWrapResultFilter());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpODataDemoWebHostModule).GetAssembly());
        }
    }
}
