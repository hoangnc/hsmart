using HSmart.DocumentManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HSmart.DocumentManagement
{
    public abstract class DocumentManagementController : AbpController
    {
        protected DocumentManagementController()
        {
            LocalizationResource = typeof(DocumentManagementResource);
        }
    }
}
