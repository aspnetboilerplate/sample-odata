using Abp.Application.Services;
using AbpODataDemo.MultiTenancy.Dto;

namespace AbpODataDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

