using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.MovieModels
{

    public class Actor
    {
        [Required]
        public int ActorId { get; set; }

        [StringLength(64), Required]
        public string FirstName { get; set; }

        [StringLength(64), Required]
        public string LastName { get; set; }

        public int GenreId { get; set; }

        public bool IsMaried { get; set; }
    }

    public partial class MovieDBContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

    }
}