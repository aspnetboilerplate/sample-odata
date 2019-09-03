using System;
using System.Reflection;
using Abp.Collections.Extensions;
using Abp.Modules;
using Abp.WebApi.OData;
using Abp.WebApi.OData.Configuration;
using AbpODataDemo.People;
using Microsoft.AspNet.OData;

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

            //TODO: Remove after ABP v0.11.2.0 upgrade
            Configuration.Validation.IgnoredTypes.AddIfNotContains(typeof(Type));
            Configuration.Validation.IgnoredTypes.AddIfNotContains(typeof(Delta));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
