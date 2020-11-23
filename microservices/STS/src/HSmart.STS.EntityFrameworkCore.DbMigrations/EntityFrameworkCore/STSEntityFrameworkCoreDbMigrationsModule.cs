using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HSmart.STS.EntityFrameworkCore
{
    [DependsOn(
        typeof(STSEntityFrameworkCoreModule)
        )]
    public class STSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<STSMigrationsDbContext>();
        }
    }
}
