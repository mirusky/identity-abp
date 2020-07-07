using Abp.Authorization;
using template.Authorization.Roles;
using template.Authorization.Users;

namespace template.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
