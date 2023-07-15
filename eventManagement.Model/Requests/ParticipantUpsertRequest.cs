using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class ParticipantUpsertRequest
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
