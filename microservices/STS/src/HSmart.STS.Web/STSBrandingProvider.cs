using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace HSmart.STS.Web
{
    [Dependency(ReplaceServices = true)]
    public class STSBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "HSmart STS";
    }
}
