using HSmart.STS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace HSmart.STS.Permissions
{
    public class STSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(STSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(STSPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<STSResource>(name);
        }
    }
}
