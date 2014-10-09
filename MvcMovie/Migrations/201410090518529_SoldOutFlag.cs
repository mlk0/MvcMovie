namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoldOutFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "IsSoldOut", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "IsSoldOut");
        }
    }
}
