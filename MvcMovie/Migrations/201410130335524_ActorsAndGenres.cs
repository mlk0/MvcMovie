namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActorsAndGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        IsMaried = c.Boolean(nullable: false),
                        Genre_GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.ActorId)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId)
                .Index(t => t.Genre_GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 1),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "Genre_GenreId", "dbo.Genres");
            DropIndex("dbo.Actors", new[] { "Genre_GenreId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Actors");
        }
    }
}
