﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class UserRoles
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
