using aspnet_events.Models;

namespace aspnet_events.Services
{
    public interface IUserEventService
    {
        Task<List<UserEvent>> GetEvents();
        Task<List<UserEvent>> RegisterToEvent(UserEvent userEvent, string userId);
        Task<List<UserEvent>> GetUsersEvents(string userId);
        Task<List<UserEvent>> GetOrganizersEvents(string userId);
        void SetEvent(UserEvent ev);
    }
}
