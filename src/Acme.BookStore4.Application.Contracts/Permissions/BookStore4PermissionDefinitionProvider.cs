using Acme.BookStore4.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore4.Permissions
{
    public class BookStore4PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStore4Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStore4Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStore4Resource>(name);
        }
    }
}
