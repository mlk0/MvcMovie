namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Description", c => c.String(maxLength: 128));
            AlterColumn("dbo.Genres", "Code", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Code", c => c.String(maxLength: 1));
            DropColumn("dbo.Genres", "Description");
        }
    }
}
