﻿using System.ComponentModel.DataAnnotations;

namespace aspnet_events.Models
{
    public class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Many-to-many
        public virtual ICollection<Event> Events { get; set; }
    }
}
