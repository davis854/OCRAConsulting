namespace ORCA2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RepliesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Replies",
                c => new
                    {
                        ReplyID = c.Int(nullable: false, identity: true),
                        MessageID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Content = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReplyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Replies");
        }
    }
}
