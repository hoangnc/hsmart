using HSmart.STS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HSmart.STS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class STSController : AbpController
    {
        protected STSController()
        {
            LocalizationResource = typeof(STSResource);
        }
    }
}