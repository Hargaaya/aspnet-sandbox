using aspnet_events.Models;

namespace aspnet_events.Services
{
    public interface IUserEventService
    {
        Task<List<UserEvent>> GetEvents();
        Task<List<UserEvent>> GetUsersEvents(User user);
        Task<List<UserEvent>> GetOrganizersEvents(User user);
        void SetEvent(UserEvent ev);
    }
}
