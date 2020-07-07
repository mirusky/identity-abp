using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using template.Authorization;

namespace template
{
    [DependsOn(
        typeof(templateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class templateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<templateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(templateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
