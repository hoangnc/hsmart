using HSmart.STS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HSmart.STS.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class STSPageModel : AbpPageModel
    {
        protected STSPageModel()
        {
            LocalizationResourceType = typeof(STSResource);
        }
    }
}