using Volo.Abp.Settings;

namespace HSmart.STS.Settings
{
    public class STSSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(STSSettings.MySetting1));
        }
    }
}
