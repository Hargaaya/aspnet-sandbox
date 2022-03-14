using aspnet_events.Models;

namespace aspnet_events.Services
{
    public interface IEventsService
    {
        List<Event> GetEvents();
        Attendee GetAttendee();
        void RegisterAttendeeToEvent(Event ev, Attendee at);
        List<Event> AttendeeRegistry(Attendee at);
    }
}
