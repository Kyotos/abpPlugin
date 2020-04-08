using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Resources.Embedded;
using MyCompany.MyProject.Plugin.Areas.Admin.Startup;
using MyCompany.MyProject.Plugin.Localization;
using System.Reflection;

namespace MyCompany.MyProject.Plugin.Startup
{
    public class PluginMvcModule : AbpModule
    {
        public PluginMvcModule()
        {
        }

        public override void PreInitialize()
        {
            PluginLocalizationConfigurer.Configure(Configuration.Localization);
            Configuration.Navigation.Providers.Add<PluginNavigationProvider>();

            Configuration.EmbeddedResources.Sources.Add(
                new EmbeddedResourceSet(
                    "/",
                    Assembly.GetExecutingAssembly(),
                    "MyCompany.MyProject.Plugin"
                    )
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PluginMvcModule).GetAssembly());
        }

        public override void PostInitialize()
        {
        }
    }
}
