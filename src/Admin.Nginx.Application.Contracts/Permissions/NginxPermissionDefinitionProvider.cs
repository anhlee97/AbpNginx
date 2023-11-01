using Admin.Nginx.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Admin.Nginx.Permissions;

public class NginxPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NginxPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NginxPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NginxResource>(name);
    }
}
