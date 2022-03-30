using Microsoft.AspNetCore.Identity;

namespace aspnet_events.Models
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // One-to-many 
        public List<UserEvent> HostedEvents { get; set; }

        // Many-to-many
        public ICollection<UserEvent> JoinedEvents { get; set; }
    }
}
