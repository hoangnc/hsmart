using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace HSmart.STS.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(STSHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class STSConsoleApiClientModule : AbpModule
    {
        
    }
}
