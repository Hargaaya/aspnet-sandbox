using System.ComponentModel.DataAnnotations;

namespace aspnet_events.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Address { get; set; }
        public DateTimeOffset Date { get; set; }
        public int SpotsAvailable { get; set; }

        // Dependent entity, One-to-many
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }

        // Many-to-many
        public ICollection<Attendee> Attendees { get; set; }

    }
}
