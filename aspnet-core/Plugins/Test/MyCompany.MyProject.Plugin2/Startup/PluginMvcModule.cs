using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Resources.Embedded;
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
