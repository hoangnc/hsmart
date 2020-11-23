using Volo.Abp.Reflection;

namespace HSmart.DocumentManagement.Permissions
{
    public class DocumentManagementPermissions
    {
        public const string GroupName = "DocumentManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DocumentManagementPermissions));
        }
    }
}