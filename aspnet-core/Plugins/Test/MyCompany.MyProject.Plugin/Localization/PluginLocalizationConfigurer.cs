using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyCompany.MyProject.Plugin.Localization
{
    public class PluginLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            if (localizationConfiguration != null)
                localizationConfiguration.Sources.Add(
                    new DictionaryBasedLocalizationSource(
                        "Plugin",
                        new XmlEmbeddedFileLocalizationDictionaryProvider(
                            typeof(PluginLocalizationConfigurer).GetAssembly(),
                            "MyCompany.MyProject.Plugin.Localization"
                        )
                    )
                );
        }
    }
}
