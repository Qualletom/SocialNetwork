namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationDb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "MobilePhone", c => c.String());
            DropColumn("dbo.Profiles", "MobilePhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "MobilePhoneNumber", c => c.String());
            DropColumn("dbo.Profiles", "MobilePhone");
        }
    }
}
