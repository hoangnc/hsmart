using Volo.Abp.Modularity;

namespace HSmart.STS
{
    [DependsOn(
        typeof(STSApplicationModule),
        typeof(STSDomainTestModule)
        )]
    public class STSApplicationTestModule : AbpModule
    {

    }
}