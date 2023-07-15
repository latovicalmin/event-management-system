using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class Participants
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public User User { get; set; }
    }
}
