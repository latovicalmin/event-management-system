﻿using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Roles
    {
        public Roles()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
