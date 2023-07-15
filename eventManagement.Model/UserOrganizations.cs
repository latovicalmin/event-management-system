using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class UserOrganizations
    {
        public int UserOrganizationId { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
    }
}
