using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
namespace DotNetNotes.Models
{
     public class Note
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        //[Display(Name = "Note Title")]
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Int32 Priority { get; set; }
        public string Text { get; set; }
        public Boolean Finished {get; set; }
        public DateTime CreationDate {get; set; }
        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime CreatedUtc { get; set; }
    }
}