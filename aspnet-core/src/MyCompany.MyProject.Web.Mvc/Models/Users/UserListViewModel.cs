using System.Collections.Generic;
using MyCompany.MyProject.Roles.Dto;

namespace MyCompany.MyProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
