using Abp.Authorization;
using Douana.Authorization.Roles;
using Douana.Authorization.Users;

namespace Douana.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
