using System;
using System.Collections.Generic;
using System.Text;
using HSmart.STS.Localization;
using Volo.Abp.Application.Services;

namespace HSmart.STS
{
    /* Inherit your application services from this class.
     */
    public abstract class STSAppService : ApplicationService
    {
        protected STSAppService()
        {
            LocalizationResource = typeof(STSResource);
        }
    }
}
