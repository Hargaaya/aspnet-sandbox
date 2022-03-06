using Microsoft.AspNetCore.Mvc;

namespace aspnet_notebook.Controllers
{
    public class NotebookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
