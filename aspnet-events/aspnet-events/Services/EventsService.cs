using aspnet_events.Models;
using aspnet_events.Data;

namespace aspnet_events.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventsContext _context;

        public EventsService(EventsContext context)
        {
            _context = context;
        }

        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }
    }
}
