namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Avatar", c => c.Binary());
            DropColumn("dbo.Profiles", "Avatar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "Avatar", c => c.Binary());
            DropColumn("dbo.AspNetUsers", "Avatar");
        }
    }
}
