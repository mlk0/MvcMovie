namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Title_with_String_Length : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
