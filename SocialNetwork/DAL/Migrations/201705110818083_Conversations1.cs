namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Conversations1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conversations", "UnreadCount", c => c.Int(nullable: false));
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsRead");
            DropColumn("dbo.Conversations", "UnreadCount");
        }
    }
}
