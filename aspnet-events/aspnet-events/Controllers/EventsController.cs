using Microsoft.AspNetCore.Mvc;

namespace aspnet_events.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Join(Guid id)
        {
            return View();
        }

        public IActionResult Confirmation(Guid id)
        {
            return View();
        }

        public IActionResult Booked()
        {
            return View();
        }
    }
}
