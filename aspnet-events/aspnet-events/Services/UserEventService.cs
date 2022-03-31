using aspnet_events.Data;
using aspnet_events.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace aspnet_events.Services
{
    public class UserEventService : IUserEventService
    {
        private AppDbContext _context;
        private UserManager<User> _userManager;

        public UserEventService(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<List<UserEvent>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<List<UserEvent>> GetOrganizersEvents(string currentUserId)
        {
            var res = await _context.Users.Where(u => u.Id == currentUserId).Include(p => p.HostedEvents).FirstOrDefaultAsync();
            return res.HostedEvents;
        }

        public async Task<List<UserEvent>> GetUsersEvents(string currentUserId)
        {
            var res = await _context.Users.Where(user => user.Id == currentUserId).Include(p => p.JoinedEvents).FirstOrDefaultAsync();
            return res.JoinedEvents.ToList();
        }

        public async Task RegisterToEvent(UserEvent userEvent, string currentUserId)
        {
            var targetEvent = await _context.Events.Where(e => e == userEvent).Include(p => p.Attendees).FirstOrDefaultAsync();
            var targetUser = await _context.Users.Where(u => u.Id == currentUserId).FirstOrDefaultAsync();

            if (targetEvent != null && targetUser != null)
            {
                targetEvent.Attendees.Add(targetUser);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SetEvent(UserEvent ev)
        {
            if (ev != null)
            {
                await _context.Events.AddAsync(ev);
                await _context.SaveChangesAsync();
            }
        }
    }
}
