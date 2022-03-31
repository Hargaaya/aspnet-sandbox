using Microsoft.AspNetCore.Identity;

namespace aspnet_events.Models
{
    public class AdminUserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool organizer { get; set; }
    }
}
