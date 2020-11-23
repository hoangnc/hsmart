using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace HSmart.DocumentManagement
{
    [DependsOn(
        typeof(DocumentManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DocumentManagementApplicationContractsModule : AbpModule
    {

    }
}
