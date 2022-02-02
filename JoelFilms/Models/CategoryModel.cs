using System;
using System.ComponentModel.DataAnnotations;

namespace JoelFilms.Models
{
    public class CategoryModel
    {
        [Key]
        [Required]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
