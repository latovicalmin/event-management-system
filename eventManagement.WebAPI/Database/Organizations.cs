using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Organizations
    {
        public Organizations()
        {
            Events = new HashSet<Events>();
            UserOrganizations = new HashSet<UserOrganizations>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public byte[] LogoThumbnail { get; set; }

        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<UserOrganizations> UserOrganizations { get; set; }
    }
}
