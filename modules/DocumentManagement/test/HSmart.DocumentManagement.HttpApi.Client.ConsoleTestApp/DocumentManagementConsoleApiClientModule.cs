using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace HSmart.DocumentManagement
{
    [DependsOn(
        typeof(DocumentManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DocumentManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
