namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Conversations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conversations",
                c => new
                    {
                        ConversationId = c.Int(nullable: false, identity: true),
                        UserFromId = c.Int(),
                        UserToId = c.Int(),
                    })
                .PrimaryKey(t => t.ConversationId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserToId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserFromId)
                .Index(t => t.UserFromId)
                .Index(t => t.UserToId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false, storeType: "date"),
                        ConversationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Conversations", t => t.ConversationId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ConversationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conversations", "UserFromId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Messages", "ConversationId", "dbo.Conversations");
            DropForeignKey("dbo.Messages", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Conversations", "UserToId", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "ConversationId" });
            DropIndex("dbo.Messages", new[] { "UserId" });
            DropIndex("dbo.Conversations", new[] { "UserToId" });
            DropIndex("dbo.Conversations", new[] { "UserFromId" });
            DropTable("dbo.Messages");
            DropTable("dbo.Conversations");
        }
    }
}
