using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class RatingUpsertRequest
    {
        [Required]
        public decimal Value { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int EventId { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
