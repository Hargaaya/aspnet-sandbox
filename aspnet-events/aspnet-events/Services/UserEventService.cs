using aspnet_events.Data;
using aspnet_events.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_events.Services
{
    public class UserEventService : IUserEventService
    {
        private AppDbContext _context;
        public UserEventService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<UserEvent>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        public Task<List<UserEvent>> GetOrganizersEvents(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEvent>> GetUsersEvents(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEvent>> RegisterToEvent(UserEvent userEvent, string userId)
        {
            throw new NotImplementedException();
        }

        public void SetEvent(UserEvent ev)
        {
            throw new NotImplementedException();
        }
    }
}
