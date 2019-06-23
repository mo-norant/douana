using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Douana.Authorization;

namespace Douana
{
    [DependsOn(
        typeof(DouanaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DouanaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DouanaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DouanaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
