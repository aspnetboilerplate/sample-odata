using System.Threading.Tasks;
using Abp.Application.Services;
using AbpODataDemo.Sessions.Dto;

namespace AbpODataDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
