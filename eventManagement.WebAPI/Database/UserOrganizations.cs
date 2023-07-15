using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class UserOrganizations
    {
        public int UserOrganizationId { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }

        public virtual Organizations Organization { get; set; }
        public virtual Users User { get; set; }
    }
}
