using HSmart.STS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace HSmart.STS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(STSEntityFrameworkCoreDbMigrationsModule),
        typeof(STSApplicationContractsModule)
        )]
    public class STSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
