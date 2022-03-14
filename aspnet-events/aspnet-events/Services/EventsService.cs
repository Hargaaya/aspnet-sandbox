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

        public Attendee GetAttendee()
        {
            return _context.Attendees.Where(a => a.AttendeeId == 1).First();
        }

        public void RegisterAttendeeToEvent(Event ev, Attendee at)
        {
            var e = _context.Events.Where(e => e == ev).FirstOrDefault();

            if (e != null)
            {
                // NEED LAZY LOADING TO NAVIGATE PROPERLY :(
                // e.Attendees.Add(at)
            }
        }

        public List<Event> AttendeeRegistry(Attendee at)
        {
            return _context.Events.Where(e => e.Attendees.Any(a => a == at)).ToList();
        }
    }
}
