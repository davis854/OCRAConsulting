namespace ORCA2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpertTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experts",
                c => new
                    {
                        ExpertID = c.Int(nullable: false, identity: true),
                        ExpertiseID = c.Int(nullable: false),
                        Validated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExpertID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Experts");
        }
    }
}
