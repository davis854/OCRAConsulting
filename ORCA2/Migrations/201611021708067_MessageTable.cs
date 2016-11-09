namespace ORCA2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        User1ID = c.Int(nullable: false),
                        User2ID = c.Int(nullable: false),
                        Title = c.String(),
                        InitialMessage = c.String(),
                    })
                .PrimaryKey(t => t.MessageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
