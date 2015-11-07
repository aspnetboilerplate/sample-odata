using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AbpODataDemo.EntityFramework;

namespace AbpODataDemo
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AbpODataDemoCoreModule))]
    public class AbpODataDemoDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AbpODataDemoDbContext>(null);
        }
    }
}
