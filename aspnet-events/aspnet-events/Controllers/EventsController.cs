using Microsoft.AspNetCore.Mvc;
using aspnet_events.Services;

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

        public IActionResult Join(int id)
        {
            return View();
        }

        public IActionResult Confirmation(int id)
        {
            return View();
        }

        public IActionResult Booked()
        {
            return View();
        }
    }
}
