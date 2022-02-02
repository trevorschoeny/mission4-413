using System;
using System.ComponentModel.DataAnnotations;

namespace JoelFilms.Models
{
    public class NewMovieModel
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        public short Year { get; set; }
        [Required(ErrorMessage = "Please enter a director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25, ErrorMessage = "Please keep notes to 25 characters or fewer")]
        public string Notes { get; set; }

        // Foreign Key to Category
        public int CategoryID { get; set; }
        public CategoryModel Category { get; set; }
    }
}
