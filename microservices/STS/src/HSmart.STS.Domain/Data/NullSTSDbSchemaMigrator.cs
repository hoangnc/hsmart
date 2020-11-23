using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HSmart.STS.Data
{
    /* This is used if database provider does't define
     * ISTSDbSchemaMigrator implementation.
     */
    public class NullSTSDbSchemaMigrator : ISTSDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}