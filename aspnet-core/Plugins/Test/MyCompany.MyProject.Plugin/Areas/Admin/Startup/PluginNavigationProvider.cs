using Abp.Application.Navigation;
using Abp.Localization;

namespace MyCompany.MyProject.Plugin.Areas.Admin.Startup
{
    public class PluginNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(new MenuItemDefinition(
                        "Plugin",
                        L("Plugin"),
                        url: "Admin/Plugin",
                        icon: "flaticon-line-graph"
                    )
            );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, "Plugin");
        }
    }
}
