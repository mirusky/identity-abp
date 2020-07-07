using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using template.Configuration.Dto;

namespace template.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : templateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
