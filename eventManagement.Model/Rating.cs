using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class Rating
    {
        public int RatingId { get; set; }
        public decimal Value { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
