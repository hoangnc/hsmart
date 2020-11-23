using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace HSmart.DocumentManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(DocumentManagementDomainSharedModule)
    )]
    public class DocumentManagementDomainModule : AbpModule
    {

    }
}
