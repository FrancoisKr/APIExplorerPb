using Volo.Abp.Settings;

namespace Acme.BookStore4.Settings
{
    public class BookStore4SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(BookStore4Settings.MySetting1));
        }
    }
}
