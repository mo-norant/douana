using System.Threading.Tasks;
using Abp.Application.Services;
using Douana.Sessions.Dto;

namespace Douana.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
