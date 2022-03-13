using aspnet_events.Models;

namespace aspnet_events.Services
{
    public interface IEventsService
    {
        List<Event> GetEvents();
    }
}
