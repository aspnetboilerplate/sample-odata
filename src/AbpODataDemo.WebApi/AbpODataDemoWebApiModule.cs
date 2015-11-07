using System.Reflection;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using AbpODataDemo.People;

namespace AbpODataDemo
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpODataDemoApplicationModule))]
    public class AbpODataDemoWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            ConfigureOData();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpODataDemoApplicationModule).Assembly, "app")
                .Build();
        }

        private void ConfigureOData()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();

            //Add your entities want to expose
            builder.EntitySet<Person>("Persons");
            
            Configuration.Modules.AbpWebApi()
                .HttpConfiguration.MapODataServiceRoute(
                    routeName: "ODataRoute",
                    routePrefix: "odata",
                    model: builder.GetEdmModel()
                );
        }
    }
}
