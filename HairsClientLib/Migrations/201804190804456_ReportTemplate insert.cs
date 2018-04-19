namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReportTemplateinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblReportTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tblImageLogo", "ReportTemplate_Id", c => c.Int());
            CreateIndex("dbo.tblImageLogo", "ReportTemplate_Id");
            AddForeignKey("dbo.tblImageLogo", "ReportTemplate_Id", "dbo.tblReportTemplate", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblImageLogo", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropIndex("dbo.tblImageLogo", new[] { "ReportTemplate_Id" });
            DropColumn("dbo.tblImageLogo", "ReportTemplate_Id");
            DropTable("dbo.tblReportTemplate");
        }
    }
}
