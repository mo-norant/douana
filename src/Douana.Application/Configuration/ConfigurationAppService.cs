using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Douana.Configuration.Dto;

namespace Douana.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DouanaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
