namespace MVCProjectBlogNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shitShitShit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropColumn("dbo.AspNetUsers", "Description");
            DropColumn("dbo.AspNetUsers", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
            AddColumn("dbo.AspNetUsers", "Description", c => c.String());
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.String());
        }
    }
}
