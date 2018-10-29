using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace W2_RazorExample.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public MovieGenres Genre { get; set; }

        public decimal Price { get; set; }
    }

    public enum MovieGenres
    {
        Action,
        Romance,
        Comedy,
        Drama
    }
}
