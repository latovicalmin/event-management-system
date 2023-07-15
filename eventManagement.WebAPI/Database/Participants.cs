using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Participants
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Events Event { get; set; }
        public virtual Users User { get; set; }
    }
}
