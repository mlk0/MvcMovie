using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.MovieModels
{
    public class Genre
    {
        [Required]
        public int GenreId { get; set; }

        [Required]
        [StringLength(1)]
        public string Code { get; set; }


        [Required]
        [StringLength(16)]
        public string Name { get; set; }


        [StringLength(128)]
        public string Description { get; set; }
    }

    public partial class MovieDBContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

    }
}