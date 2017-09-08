using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotNetNotes.Models;
using DotNetNotes.Data;

namespace Controllers
{
    public class NoteController : Controller 
    {
        private readonly ApplicationDbContext _context;
        public NoteController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Note newNote)
        {
            _context.Note.Add(newNote);
            _context.SaveChanges();
            //return RedirectToAction("Detail", new {Id = newOrder.Id});
            return View("Index", newNote);
        }

        public IActionResult Edit()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
