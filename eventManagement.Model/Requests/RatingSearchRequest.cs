using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class RatingSearchRequest
    {
        public int? UserId { get; set; }
        public int? EventId { get; set; }
    }
}
