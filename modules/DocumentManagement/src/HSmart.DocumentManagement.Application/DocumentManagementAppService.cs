using HSmart.DocumentManagement.Localization;
using Volo.Abp.Application.Services;

namespace HSmart.DocumentManagement
{
    public abstract class DocumentManagementAppService : ApplicationService
    {
        protected DocumentManagementAppService()
        {
            LocalizationResource = typeof(DocumentManagementResource);
            ObjectMapperContext = typeof(DocumentManagementApplicationModule);
        }
    }
}
