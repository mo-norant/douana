using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Douana.MultiTenancy.Dto;

namespace Douana.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

