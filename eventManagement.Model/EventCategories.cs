using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class EventCategories
    {
        public int EventCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int EventId { get; set; }
        public Category Category { get; set; }
        public Event Event { get; set; }
    }
}
