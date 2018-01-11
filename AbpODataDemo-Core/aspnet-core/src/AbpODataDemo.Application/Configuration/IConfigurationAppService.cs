using System.Threading.Tasks;
using AbpODataDemo.Configuration.Dto;

namespace AbpODataDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
