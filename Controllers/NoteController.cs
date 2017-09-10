using System.Linq;
using System.Threading;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var data = _context.Note.OrderBy(a => a.Title);

        return View(data);
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
            return RedirectToAction("Index");
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
