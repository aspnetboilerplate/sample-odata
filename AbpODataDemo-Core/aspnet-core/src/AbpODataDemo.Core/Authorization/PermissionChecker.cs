using Abp.Authorization;
using AbpODataDemo.Authorization.Roles;
using AbpODataDemo.Authorization.Users;

namespace AbpODataDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
