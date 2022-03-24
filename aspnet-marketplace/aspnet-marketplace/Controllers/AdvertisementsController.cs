using Microsoft.AspNetCore.Mvc;

namespace aspnet_marketplace.Controllers
{
    public class AdvertisementsController : Controller
    {
        [HttpPost]
        public IActionResult search(string searchParam, int catId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult category(int catId)
        {
            return View();
        }
    }
}
