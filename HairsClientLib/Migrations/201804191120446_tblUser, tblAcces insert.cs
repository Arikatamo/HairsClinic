namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUsertblAccesinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAccesRight",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccessName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.Binary(nullable: false, maxLength: 256),
                        LinseId = c.Int(nullable: false),
                        ResearchId = c.Int(nullable: false),
                        ConfigsId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        AccesRightId = c.Int(nullable: false),
                        ReporsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblAccesRight", t => t.AccesRightId, cascadeDelete: true)
                .ForeignKey("dbo.tblConfigHair", t => t.ConfigsId, cascadeDelete: true)
                .ForeignKey("dbo.tblContscts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.tblObjectives", t => t.LinseId, cascadeDelete: true)
                .Index(t => t.LinseId)
                .Index(t => t.ConfigsId)
                .Index(t => t.ContactId)
                .Index(t => t.AccesRightId);
            
            AddColumn("dbo.tblReportTemplate", "User_Id", c => c.Int());
            AddColumn("dbo.tblResearch", "User_Id", c => c.Int());
            CreateIndex("dbo.tblReportTemplate", "User_Id");
            CreateIndex("dbo.tblResearch", "User_Id");
            AddForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser", "Id");
            AddForeignKey("dbo.tblResearch", "User_Id", "dbo.tblUser", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblUser", "LinseId", "dbo.tblObjectives");
            DropForeignKey("dbo.tblUser", "ContactId", "dbo.tblContscts");
            DropForeignKey("dbo.tblUser", "ConfigsId", "dbo.tblConfigHair");
            DropForeignKey("dbo.tblUser", "AccesRightId", "dbo.tblAccesRight");
            DropIndex("dbo.tblUser", new[] { "AccesRightId" });
            DropIndex("dbo.tblUser", new[] { "ContactId" });
            DropIndex("dbo.tblUser", new[] { "ConfigsId" });
            DropIndex("dbo.tblUser", new[] { "LinseId" });
            DropIndex("dbo.tblResearch", new[] { "User_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            DropColumn("dbo.tblResearch", "User_Id");
            DropColumn("dbo.tblReportTemplate", "User_Id");
            DropTable("dbo.tblUser");
            DropTable("dbo.tblAccesRight");
        }
    }
}
