using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DotNetNotes.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Note
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        //[Display(Name = "Note Title")]
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Text { get; set; }
    }
}