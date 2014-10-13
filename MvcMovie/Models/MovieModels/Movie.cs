using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.MovieModels
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(64, MinimumLength=3)]
        public string Title { get; set; }

        [Display(Name="Release Date", ShortName="RelDt.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(32)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        public string Genre { get; set; }

        [Range(1,200)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Rating { get; set; }

        [Display(Name="Is Sold Out", ShortName="SldOut")]        
        public bool IsSoldOut { get; set; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}