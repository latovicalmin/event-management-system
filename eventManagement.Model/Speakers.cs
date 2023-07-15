using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class Speakers
    {
        public int SpeakerId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public User User { get; set; }
    }
}
