using System.Linq;
using System.Threading;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetNotes.Models;
using DotNetNotes.Data;
using System;

namespace Controllers
{
    public class NoteController : Controller 
    {
        private readonly ApplicationDbContext _context;
        public NoteController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string orderby = null)
        {  
            var data = _context.Note.OrderBy(a => a.Title);
            switch (orderby)
            {
                case "prio":
                data = _context.Note.OrderBy(a => a.Priority);
                break;

                case "due":
                data = _context.Note.OrderBy(a => a.DueDate);
                break;

                case "creation":
                data = _context.Note.OrderBy(a => a.CreationDate);
                break;

                default:
                data = _context.Note.OrderBy(a => a.Title);
                break;
            }
            

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
            newNote.CreationDate = DateTime.Now;
            _context.Note.Add(newNote);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var note = _context.Note.FirstOrDefault(x => x.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            _context.Note.Remove(note);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            var note = _context.Note.FirstOrDefault(x => x.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }
                    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("Id, Title, Priority, CreationDate, DueDate, Text, Finished")] Note note)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(note).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        return View(note);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
