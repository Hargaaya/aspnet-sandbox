using aspnet_events.Models;

namespace aspnet_events.Services
{
    public interface IUserEventService
    {
        Task<List<UserEvent>> GetEvents();
        Task RegisterToEvent(UserEvent userEvent, string userId);
        Task<List<UserEvent>> GetUsersEvents(string userId);
        Task<List<UserEvent>> GetOrganizersEvents(string userId);
        Task SetEvent(UserEvent ev);
    }
}
