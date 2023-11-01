using Volo.Abp.Settings;

namespace Admin.Nginx.Settings;

public class NginxSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NginxSettings.MySetting1));
    }
}
