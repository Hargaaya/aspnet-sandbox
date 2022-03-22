using Microsoft.AspNetCore.Mvc;

namespace aspnet_marketplace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Marketplace";
            return View();
        }
    }
}
