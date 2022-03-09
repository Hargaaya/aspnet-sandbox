using Microsoft.AspNetCore.Mvc;
using aspnet_notebook.Data;
using aspnet_notebook.Models;

namespace aspnet_notebook.Controllers
{
    public class NotebookController : Controller
    {
        public NotebookContext _context { get; set; }

        public NotebookController(NotebookContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
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

            NotebookItem newNote = new NotebookItem { Title = title, Text = text };
            _context.NotebookItems.Add(newNote);
            _context.SaveChanges();

            return View("Success", newNote);
        }
    }
}
