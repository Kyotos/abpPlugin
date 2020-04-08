﻿using System.Collections.Generic;
using MyCompany.MyProject.Roles.Dto;

namespace MyCompany.MyProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
