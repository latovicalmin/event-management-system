using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class EventSearchRequest
    {
        public string Name { get; set; }
        public int? OrganizationId { get; set; }
        public int? CityId { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
