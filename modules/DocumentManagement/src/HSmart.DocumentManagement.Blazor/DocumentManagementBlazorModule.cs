using Microsoft.Extensions.DependencyInjection;
using HSmart.DocumentManagement.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace HSmart.DocumentManagement.Blazor
{
    [DependsOn(
        typeof(DocumentManagementHttpApiClientModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DocumentManagementBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<DocumentManagementBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<DocumentManagementBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new DocumentManagementMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(DocumentManagementBlazorModule).Assembly);
            });
        }
    }
}