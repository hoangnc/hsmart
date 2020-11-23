using HSmart.STS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace HSmart.STS
{
    [DependsOn(
        typeof(STSEntityFrameworkCoreTestModule)
        )]
    public class STSDomainTestModule : AbpModule
    {

    }
}