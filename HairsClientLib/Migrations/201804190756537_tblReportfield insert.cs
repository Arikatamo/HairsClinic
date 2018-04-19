namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblReportfieldinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblReportfield",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameDiagnos = c.String(nullable: false, maxLength: 100),
                        FieldTypeId = c.Int(nullable: false),
                        FieldVariantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblFieldType", t => t.FieldTypeId, cascadeDelete: true)
                .ForeignKey("dbo.tblFieldVariants", t => t.FieldVariantId, cascadeDelete: true)
                .Index(t => t.FieldTypeId)
                .Index(t => t.FieldVariantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblReportfield", "FieldVariantId", "dbo.tblFieldVariants");
            DropForeignKey("dbo.tblReportfield", "FieldTypeId", "dbo.tblFieldType");
            DropIndex("dbo.tblReportfield", new[] { "FieldVariantId" });
            DropIndex("dbo.tblReportfield", new[] { "FieldTypeId" });
            DropTable("dbo.tblReportfield");
        }
    }
}
