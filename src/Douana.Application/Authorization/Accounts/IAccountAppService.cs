using System.Threading.Tasks;
using Abp.Application.Services;
using Douana.Authorization.Accounts.Dto;

namespace Douana.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
