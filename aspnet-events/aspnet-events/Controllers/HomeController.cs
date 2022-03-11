using Microsoft.AspNetCore.Mvc;

namespace aspnet_events.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}