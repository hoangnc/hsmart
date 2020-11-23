using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace HSmart.DocumentManagement.EntityFrameworkCore
{
    public class DocumentManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DocumentManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}