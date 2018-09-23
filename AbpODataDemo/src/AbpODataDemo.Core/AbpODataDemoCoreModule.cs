using System.Reflection;
using Abp.Modules;

namespace AbpODataDemo
{
    public class AbpODataDemoCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
