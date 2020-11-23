using Volo.Abp.Modularity;

namespace HSmart.DocumentManagement
{
    [DependsOn(
        typeof(DocumentManagementApplicationModule),
        typeof(DocumentManagementDomainTestModule)
        )]
    public class DocumentManagementApplicationTestModule : AbpModule
    {

    }
}
