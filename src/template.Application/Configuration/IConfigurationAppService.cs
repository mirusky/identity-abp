using System.Threading.Tasks;
using template.Configuration.Dto;

namespace template.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
