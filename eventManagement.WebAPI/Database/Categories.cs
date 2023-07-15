using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Categories
    {
        public Categories()
        {
            EventCategories = new HashSet<EventCategories>();
            Events = new HashSet<Events>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EventCategories> EventCategories { get; set; }
        public virtual ICollection<Events> Events { get; set; }
    }
}
