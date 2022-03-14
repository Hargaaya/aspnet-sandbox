using System.ComponentModel.DataAnnotations;

namespace aspnet_events.Models
{
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Principal entity, One-to-many
        public virtual List<Event> Events { get; set; }
    }
}
