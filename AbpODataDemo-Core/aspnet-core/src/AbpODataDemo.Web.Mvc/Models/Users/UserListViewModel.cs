using System.Collections.Generic;
using AbpODataDemo.Roles.Dto;
using AbpODataDemo.Users.Dto;

namespace AbpODataDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
