using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpODataDemo.Roles.Dto;

namespace AbpODataDemo.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
