namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblResearchinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblResearch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResearchTypeId = c.Int(nullable: false),
                        ResearchStatusId = c.Int(nullable: false),
                        Thunmbnail = c.Binary(nullable: false),
                        PhotosId = c.Int(nullable: false),
                        HairsId = c.Int(nullable: false),
                        ResearchArea = c.Int(nullable: false),
                        Commentary = c.String(nullable: false, maxLength: 2000),
                        TimeResearch = c.DateTime(nullable: false),
                        DiagnosId = c.Int(nullable: false),
                        Treatment = c.String(nullable: false),
                        ConfigId = c.Int(nullable: false),
                        ObjectiveId = c.Int(nullable: false),
                        ReportTemplateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblConfigHair", t => t.ConfigId, cascadeDelete: true)
                .ForeignKey("dbo.tblDiagnoses", t => t.DiagnosId, cascadeDelete: true)
                .ForeignKey("dbo.tblHair", t => t.HairsId, cascadeDelete: true)
                .ForeignKey("dbo.tblObjectives", t => t.ObjectiveId, cascadeDelete: true)
                .ForeignKey("dbo.tblPhotoses", t => t.PhotosId, cascadeDelete: true)
                .ForeignKey("dbo.tblResearchStatus", t => t.ResearchStatusId, cascadeDelete: true)
                .ForeignKey("dbo.tblResearchType", t => t.ResearchTypeId, cascadeDelete: true)
                .Index(t => t.ResearchTypeId)
                .Index(t => t.ResearchStatusId)
                .Index(t => t.PhotosId)
                .Index(t => t.HairsId)
                .Index(t => t.DiagnosId)
                .Index(t => t.ConfigId)
                .Index(t => t.ObjectiveId);
            
            CreateTable(
                "dbo.tblResearchType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tblReportTemplate", "Research_Id", c => c.Int());
            CreateIndex("dbo.tblReportTemplate", "Research_Id");
            AddForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "ResearchTypeId", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatusId", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropForeignKey("dbo.tblResearch", "PhotosId", "dbo.tblPhotoses");
            DropForeignKey("dbo.tblResearch", "ObjectiveId", "dbo.tblObjectives");
            DropForeignKey("dbo.tblResearch", "HairsId", "dbo.tblHair");
            DropForeignKey("dbo.tblResearch", "DiagnosId", "dbo.tblDiagnoses");
            DropForeignKey("dbo.tblResearch", "ConfigId", "dbo.tblConfigHair");
            DropIndex("dbo.tblResearch", new[] { "ObjectiveId" });
            DropIndex("dbo.tblResearch", new[] { "ConfigId" });
            DropIndex("dbo.tblResearch", new[] { "DiagnosId" });
            DropIndex("dbo.tblResearch", new[] { "HairsId" });
            DropIndex("dbo.tblResearch", new[] { "PhotosId" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatusId" });
            DropIndex("dbo.tblResearch", new[] { "ResearchTypeId" });
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            DropColumn("dbo.tblReportTemplate", "Research_Id");
            DropTable("dbo.tblResearchType");
            DropTable("dbo.tblResearch");
        }
    }
}
