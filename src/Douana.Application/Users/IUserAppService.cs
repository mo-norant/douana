using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Douana.Roles.Dto;
using Douana.Users.Dto;

namespace Douana.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
