using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Events
    {
        public Events()
        {
            Comments = new HashSet<Comments>();
            EventCategories = new HashSet<EventCategories>();
            Participants = new HashSet<Participants>();
            Ratings = new HashSet<Ratings>();
            Speakers = new HashSet<Speakers>();
        }

        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? Coatization { get; set; }
        public decimal? Duration { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int OrganizationId { get; set; }
        public int? MaxPlaces { get; set; }
        public int? CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Cities City { get; set; }
        public virtual Organizations Organization { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<EventCategories> EventCategories { get; set; }
        public virtual ICollection<Participants> Participants { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Speakers> Speakers { get; set; }
    }
}
