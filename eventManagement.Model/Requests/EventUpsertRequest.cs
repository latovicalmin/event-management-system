using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class EventUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? Coatization { get; set; }
        public decimal? Duration { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Address { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public int OrganizationId { get; set; }
        public int? MaxPlaces { get; set; }
        public List<int> SpeakerIDs { get; set; } = new List<int>();
    }
}
