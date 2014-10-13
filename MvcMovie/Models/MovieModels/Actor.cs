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
        [Display(Name="First Name", ShortName="FN")]
        public string FirstName { get; set; }

        [StringLength(64), Required, Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name="Genre")]
        public int GenreId { get; set; }

        [Display(Name="Is Married?")]
        public bool IsMaried { get; set; }
    }

    public partial class MovieDBContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

    }
}