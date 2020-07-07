using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using template.EntityFrameworkCore;
using template.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace template.Web.Tests
{
    [DependsOn(
        typeof(templateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class templateWebTestModule : AbpModule
    {
        public templateWebTestModule(templateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(templateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(templateWebMvcModule).Assembly);
        }
    }
}