using Volo.Abp.Settings;

namespace StockManagementApp.Settings;

public class StockManagementAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StockManagementAppSettings.MySetting1));
    }
}
