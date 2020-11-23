using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace HSmart.DocumentManagement.EntityFrameworkCore
{
    public class DocumentManagementHttpApiHostMigrationsDbContext : AbpDbContext<DocumentManagementHttpApiHostMigrationsDbContext>
    {
        public DocumentManagementHttpApiHostMigrationsDbContext(DbContextOptions<DocumentManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureDocumentManagement();
            modelBuilder.ConfigureAuditLogging();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
        }
    }
}
