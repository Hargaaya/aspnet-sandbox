using Microsoft.AspNetCore.Mvc;
using aspnet_events.Services;
using aspnet_events.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace aspnet_events.Controllers
{
    public class EventsController : Controller
    {

        private IUserEventService _es;
        private UserManager<User> _us;


        public EventsController(IUserEventService eventsService, UserManager<User> userManager)
        {
            _es = eventsService;
            _us = userManager;
        }


        public async Task<IActionResult> IndexAsync()
        {
            ViewBag.Events = await _es.GetEvents();
            return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> JoinAsync(int id)
        {
            var res = await _es.GetEvents();
            var ev = res.Where(d => d.EventId == id).First();
            return View(ev);
        }

        [Authorize]
        [HttpPost]
        [ActionName("Join")]
        public IActionResult Confirmation(int id)
        {
            var res = _es.GetEvents();
            var ev = res.Where(d => d.EventId == id).First();

            ClaimsPrincipal CurrentUser = this.User;
            string UserId = CurrentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

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
        */
    }
}
