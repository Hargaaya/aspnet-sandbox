using Microsoft.AspNetCore.Mvc;
using aspnet_notebook.Data;
using aspnet_notebook.Models;
using System.Linq;

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
            ViewBag.list = _context.NotebookItems.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New([Bind("Title,Text")] NotebookItem newNote)
        {
            Console.WriteLine($"the title is: {newNote.Title}, and the text: {newNote.Text}");

            _context.NotebookItems.Add(newNote);
            _context.SaveChanges();

            return View("Success", newNote);
        }

        public IActionResult Note(Guid id)
        {
            var note = _context.NotebookItems.Where(item => item.ItemId == id).FirstOrDefault();
            if (note != null)
            {
                note.IsRead = true;
                _context.SaveChanges();
            }
            Console.WriteLine(note);
            return View(note);
        }
    }
}
