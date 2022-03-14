using Microsoft.AspNetCore.Mvc;
using aspnet_events.Services;
using aspnet_events.Models;

namespace aspnet_events.Controllers
{
    public class EventsController : Controller
    {

        private IEventsService _es;

        public EventsController(IEventsService eventsService)
        {
            _es = eventsService;
        }


        public IActionResult Index()
        {
            ViewBag.Events = _es.GetEvents();
            return View();
        }

        [HttpGet]
        public IActionResult Join(int id)
        {
            Event? ev = _es.GetEvents().Where(d => d.EventId == id).First();
            Console.WriteLine("Im here");
            return View(ev);
        }

        [HttpPost]
        [ActionName("Join")]
        public IActionResult Confirmation(int id)
        {
            Event? ev = _es.GetEvents().Where(d => d.EventId == id).First();
            Attendee at = _es.GetAttendee();
            _es.RegisterAttendeeToEvent(ev, at);

            return View("Confirmation", ev);
        }

        public IActionResult Booked()
        {
            var myEvents = _es.AttendeeRegistry(_es.GetAttendee());
            foreach (var ev in myEvents)
            {
                Console.WriteLine(ev.Title);
            }
            return View(myEvents);
        }
    }
}
