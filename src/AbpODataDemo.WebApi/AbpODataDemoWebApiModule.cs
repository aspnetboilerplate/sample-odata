using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Abp.WebApi.OData.Configuration;
using AbpODataDemo.People;

namespace AbpODataDemo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpODataDemoApplicationModule))]
    public class AbpODataDemoWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebApiOData().ODataModelBuilder.EntitySet<Person>("Persons");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpODataDemoApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
