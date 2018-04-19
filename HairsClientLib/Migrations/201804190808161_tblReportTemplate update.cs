namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblReportTemplateupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblFieldType", "ReportTemplate_Id", c => c.Int());
            AddColumn("dbo.tblReportfield", "ReportTemplate_Id", c => c.Int());
            AddColumn("dbo.tblReportTemplate", "FieldTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.tblReportTemplate", "ReportFieldId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblFieldType", "ReportTemplate_Id");
            CreateIndex("dbo.tblReportfield", "ReportTemplate_Id");
            AddForeignKey("dbo.tblFieldType", "ReportTemplate_Id", "dbo.tblReportTemplate", "Id");
            AddForeignKey("dbo.tblReportfield", "ReportTemplate_Id", "dbo.tblReportTemplate", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblReportfield", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropForeignKey("dbo.tblFieldType", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropIndex("dbo.tblReportfield", new[] { "ReportTemplate_Id" });
            DropIndex("dbo.tblFieldType", new[] { "ReportTemplate_Id" });
            DropColumn("dbo.tblReportTemplate", "ReportFieldId");
            DropColumn("dbo.tblReportTemplate", "FieldTypeId");
            DropColumn("dbo.tblReportfield", "ReportTemplate_Id");
            DropColumn("dbo.tblFieldType", "ReportTemplate_Id");
        }
    }
}
