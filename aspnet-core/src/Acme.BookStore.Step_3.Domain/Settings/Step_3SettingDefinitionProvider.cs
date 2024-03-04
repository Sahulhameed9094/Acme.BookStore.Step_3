using Volo.Abp.Settings;

namespace Acme.BookStore.Step_3.Settings;

public class Step_3SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Step_3Settings.MySetting1));
    }
}
