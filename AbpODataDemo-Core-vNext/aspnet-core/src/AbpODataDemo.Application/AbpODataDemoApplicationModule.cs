using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpODataDemo.Authorization;

namespace AbpODataDemo
{
    [DependsOn(
        typeof(AbpODataDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpODataDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpODataDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpODataDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
