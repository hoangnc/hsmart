using HSmart.DocumentManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HSmart.DocumentManagement.Permissions
{
    public class DocumentManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DocumentManagementPermissions.GroupName, L("Permission:DocumentManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DocumentManagementResource>(name);
        }
    }
}