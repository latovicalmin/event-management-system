using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateTime { get; set; }
        public string DateTimeFormatted { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? Coatization { get; set; }
        public decimal? Duration { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int OrganizationId { get; set; }
        public int CategoryId { get; set; }
        public int? MaxPlaces { get; set; }
        public string TotalRatings { get; set; }
        public string AverageRating { get; set; }

        public City City { get; set; }
        public Category Category { get; set; }
        public Organization Organization { get; set; }
        public virtual ICollection<Speakers> Speakers { get; set; }
        public virtual ICollection<Participants> Participants { get; set; }
    }
}
