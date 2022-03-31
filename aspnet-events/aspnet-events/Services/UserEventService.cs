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

        public async Task<List<User>> GetUsers()
        {
            var orgRole = await _context.Roles.Where(r => r.Name == "Organizer").FirstOrDefaultAsync();
            var users = await _context.Users.ToListAsync();
            var userRoles = await _context.UserRoles.ToListAsync();

            var joined = users.Join(
                userRoles,
                u => u.Id,
                r => r.UserId, (u, r) => new AdminUserModel { UserName = u.UserName, Email = u.Email, organizer = (r.RoleId == orgRole.Id) }).ToList();

            return users;
        }

        public async Task<List<AdminUserModel>> GetUsersWithOrg()
        {
            var orgRole = await _context.Roles.Where(r => r.Name == "Organizer").FirstOrDefaultAsync();
            var users = await _context.Users.ToListAsync();
            var userRoles = await _context.UserRoles.ToListAsync();

            var joined = users.Join(
                userRoles,
                u => u.Id,
                r => r.UserId, (u, r) => new AdminUserModel { UserName = u.UserName, Email = u.Email, organizer = (r.RoleId == orgRole.Id) }).ToList();

            return joined;
        }

        public async Task<List<UserEvent>> GetOrganizersEvents(string currentUserId)
        {
            var res = await _context.Users.Where(u => u.Id == currentUserId).Include(p => p.HostedEvents).FirstOrDefaultAsync();
            return res.HostedEvents;
        }

        public async Task<List<UserEvent>> GetUsersEvents(string currentUserId)
        {
            var res = await _context.Users.Where(user => user.Id == currentUserId).Include(p => p.JoinedEvents).Select(p => p.JoinedEvents).FirstAsync();
            var users = await this.GetUsers();

            var joined = res.ToList().Join(users, r => r.OrganizerId, u => u.Id, (u, r) => new UserEvent { Title = u.Title, Date = u.Date, Place = u.Place, Organizer = r });

            return joined.ToList();
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
