using System.Reflection;
using Abp.Modules;

namespace AbpODataDemo
{
    [DependsOn(typeof(AbpODataDemoCoreModule))]
    public class AbpODataDemoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
