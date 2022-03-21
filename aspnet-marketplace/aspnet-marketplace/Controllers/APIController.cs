using Microsoft.AspNetCore.Mvc;
using aspnet_marketplace.Services;

namespace aspnet_marketplace.Controllers
{
    public class APIController : Controller
    {

        private IAdService _ase;

        public APIController(IAdService ase)
        {
            _ase = ase;
        }

        public IActionResult advertisements()
        {
            return Ok(_ase.GetAdvertisementList());
        }
    }
}
