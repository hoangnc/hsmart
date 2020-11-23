using System.Threading.Tasks;
using HSmart.DocumentManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace HSmart.DocumentManagement.Blazor.Host
{
    public class DocumentManagementHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<DocumentManagementResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "DocumentManagement.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
