﻿namespace NetCoreIdentity.Web.Areas.Admin.Models
{
    public class AssignRoleToUserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Exist { get; set; }
    }
}
