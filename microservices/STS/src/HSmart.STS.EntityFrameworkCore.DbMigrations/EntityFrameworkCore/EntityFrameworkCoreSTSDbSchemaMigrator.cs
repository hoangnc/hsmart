using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HSmart.STS.Data;
using Volo.Abp.DependencyInjection;

namespace HSmart.STS.EntityFrameworkCore
{
    public class EntityFrameworkCoreSTSDbSchemaMigrator
        : ISTSDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSTSDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the STSMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<STSMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}