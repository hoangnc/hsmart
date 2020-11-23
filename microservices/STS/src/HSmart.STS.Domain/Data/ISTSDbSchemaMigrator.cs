using System.Threading.Tasks;

namespace HSmart.STS.Data
{
    public interface ISTSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
