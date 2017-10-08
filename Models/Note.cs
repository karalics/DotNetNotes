using System;
using System.ComponentModel.DataAnnotations;
namespace DotNetNotes.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [Range(1,5, ErrorMessage="The {0} must be between between 1 and 5.")]
        public Int32 Priority { get; set; }
        [Required]
        public string Text { get; set; }
        public Boolean Finished {get; set; }
        public DateTime CreationDate {get; set; }
        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime CreatedUtc { get; set; }
    }
}