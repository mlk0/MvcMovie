namespace MvcMovie.Migrations
{
    using MvcMovie.Models.MovieModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieModels.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieModels.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(
                c => c.Title,
                new Movie
                {
                    Title = "Busava Azbuka",
                    Genre = "Obrazovna Programa",
                    Price = 30,
                    ReleaseDate = new DateTime(1985, 04, 05),
                    Rating = "G"
                },
                new Movie 
                {
                    Title = "Tetoviranje",
                    Genre = "Drama",
                    Price = 62,
                    ReleaseDate = new DateTime(1988, 03, 22),
                    Rating = "NC-17"
                },
                new Movie
                {
                    Title = "Balkan Kan",
                    Genre = "Komedija",
                    Price = 59,
                    ReleaseDate = new DateTime(2005, 10, 09),
                    Rating = "PG-13"
                },
                new Movie
                {
                    Title = "Sampionite od Sutka",
                    Genre = "Komedija",
                    Price = 28,
                    ReleaseDate = new DateTime(2008, 3, 8),
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Senki",
                    Genre = "Drama",
                    Price = 55,
                    ReleaseDate = new DateTime(2010, 4, 18),
                    Rating = "R"
                }
                );
        }   
    }
}
