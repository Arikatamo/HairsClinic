namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblHairinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblHair",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Width = c.Int(nullable: false),
                        x1 = c.Int(nullable: false),
                        y1 = c.Int(nullable: false),
                        x2 = c.Int(nullable: false),
                        y2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblHair");
        }
    }
}
