using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class EventCategories
    {
        public int EventCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int EventId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Events Event { get; set; }
    }
}
