namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationDb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Avatar", c => c.Binary());
            AddColumn("dbo.Profiles", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Profiles", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.AspNetUsers", "Avatar");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Avatar", c => c.Binary());
            DropColumn("dbo.Profiles", "LastName");
            DropColumn("dbo.Profiles", "FirstName");
            DropColumn("dbo.Profiles", "Avatar");
        }
    }
}
