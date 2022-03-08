using Microsoft.AspNetCore.Mvc;
using aspnet_notebook.Models;

namespace aspnet_notebook.Controllers
{
    public class NotebookController : Controller
    {
        public IActionResult Index()
        {
            ViewData["What"] = "This passes into view O_o";
            return View();
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(string title, string text)
        {
            Console.WriteLine($"the title is: {title}, and the text: {text}");

            NotebookItem newItem = new NotebookItem { Title = title, Text = text };
            return View("Success", newItem);
        }
    }
}
