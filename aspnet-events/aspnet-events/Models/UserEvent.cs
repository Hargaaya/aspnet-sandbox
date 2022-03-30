using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet_events.Models
{
    public class UserEvent
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
        [ForeignKey("User")]
        public string OrganizerId { get; set; }
        public User Organizer { get; set; }

        // Many-to-many
        public ICollection<User> Attendees { get; set; }

    }
}
