namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblFieldVariantstblImageLogotblFieldTypetblReportfieldinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblFieldType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblFieldVariants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAndina = c.String(nullable: false, maxLength: 100),
                        Selected = c.Boolean(nullable: false),
                        Text = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblImageLogo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Selected = c.Boolean(nullable: false),
                        Data = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblImageLogo");
            DropTable("dbo.tblFieldVariants");
            DropTable("dbo.tblFieldType");
        }
    }
}
