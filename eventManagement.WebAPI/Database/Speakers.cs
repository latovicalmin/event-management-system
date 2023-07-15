using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Speakers
    {
        public int SpeakerId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }

        public virtual Events Event { get; set; }
        public virtual Users User { get; set; }
    }
}
