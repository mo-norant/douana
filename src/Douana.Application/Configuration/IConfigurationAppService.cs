using System.Threading.Tasks;
using Douana.Configuration.Dto;

namespace Douana.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
