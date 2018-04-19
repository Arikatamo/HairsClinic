namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblGenderandtblContacts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblContscts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        SecondName = c.String(nullable: false, maxLength: 100),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        GenderSId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblGender", t => t.GenderSId, cascadeDelete: true)
                .Index(t => t.GenderSId);
            
            CreateTable(
                "dbo.tblGender",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblContscts", "GenderSId", "dbo.tblGender");
            DropIndex("dbo.tblContscts", new[] { "GenderSId" });
            DropTable("dbo.tblGender");
            DropTable("dbo.tblContscts");
        }
    }
}
