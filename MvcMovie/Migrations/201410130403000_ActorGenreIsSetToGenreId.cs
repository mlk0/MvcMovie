namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorGenreIsSetToGenreId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Actors", "Genre_GenreId", "dbo.Genres");
            DropIndex("dbo.Actors", new[] { "Genre_GenreId" });
            AddColumn("dbo.Actors", "GenreId", c => c.Int(nullable: false));
            DropColumn("dbo.Actors", "Genre_GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Actors", "Genre_GenreId", c => c.Int());
            DropColumn("dbo.Actors", "GenreId");
            CreateIndex("dbo.Actors", "Genre_GenreId");
            AddForeignKey("dbo.Actors", "Genre_GenreId", "dbo.Genres", "GenreId");
        }
    }
}
