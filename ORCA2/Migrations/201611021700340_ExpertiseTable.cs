namespace ORCA2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpertiseTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expertises",
                c => new
                    {
                        ExpertiseID = c.Int(nullable: false, identity: true),
                        Department = c.String(),
                        Field = c.String(),
                    })
                .PrimaryKey(t => t.ExpertiseID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expertises");
        }
    }
}
