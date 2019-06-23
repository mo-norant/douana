using System.Collections.Generic;
using Douana.Roles.Dto;
using Douana.Users.Dto;

namespace Douana.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
