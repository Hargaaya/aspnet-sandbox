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
        public async Task<IActionResult> ConfirmationAsync(int id)
        {
            var res = await _es.GetEvents();
            var ev = res.Where(d => d.EventId == id).First();

            await _es.RegisterToEvent(ev, this.GetCurrentUserId());

            return View("Confirmation", ev);
        }

        public async Task<IActionResult> BookedAsync()
        {
            var myEvents = await _es.GetUsersEvents(this.GetCurrentUserId());
            return View(myEvents);
        }

        public string GetCurrentUserId()
        {
            ClaimsPrincipal CurrentUser = this.User;
            return CurrentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
