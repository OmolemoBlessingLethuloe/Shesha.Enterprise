using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Zero;
using Shesha.Startup;
using System.Reflection;

namespace Shesha.Enterprise.Domain
{
    [DependsOn(
        typeof(AbpZeroCoreModule),
        typeof(SheshaFrameworkModule),
        typeof(AbpAspNetCoreModule)
        )]
    public class SheshaEnterpriseModule : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = Assembly.GetExecutingAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }

        /// inheritedDoc
        public override void PostInitialize()
        {
            Configuration.Modules.ShaApplication().CreateAppServicesForEntities(typeof(SheshaEnterpriseModule).Assembly, "Enterprise");
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(
                typeof(SheshaEnterpriseModule).Assembly,
                moduleName: "Enterprise",
                useConventionalHttpVerbs: true);
        }
    }
}
