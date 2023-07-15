using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class Organization
    {

        public int? OrganizationId { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public byte[] LogoThumbnail { get; set; }
    }
}
