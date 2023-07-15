using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Cities
    {
        public Cities()
        {
            Events = new HashSet<Events>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Countries Country { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}
