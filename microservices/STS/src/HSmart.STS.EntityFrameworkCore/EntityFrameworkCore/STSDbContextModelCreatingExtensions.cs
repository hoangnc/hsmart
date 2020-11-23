using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace HSmart.STS.EntityFrameworkCore
{
    public static class STSDbContextModelCreatingExtensions
    {
        public static void ConfigureSTS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(STSConsts.DbTablePrefix + "YourEntities", STSConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}