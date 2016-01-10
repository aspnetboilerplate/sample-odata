using System.Reflection;
using Abp.Modules;
using Abp.WebApi.OData;
using Abp.WebApi.OData.Configuration;
using AbpODataDemo.People;

namespace AbpODataDemo
{
    [DependsOn(typeof(AbpWebApiODataModule))]
    public class AbpODataDemoWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            var builder = Configuration.Modules.AbpWebApiOData().ODataModelBuilder;

            //Configure your entities here...
            builder.EntitySet<Person>("Persons");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
