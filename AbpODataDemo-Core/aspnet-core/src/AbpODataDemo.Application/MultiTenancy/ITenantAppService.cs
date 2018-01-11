using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpODataDemo.MultiTenancy.Dto;

namespace AbpODataDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
