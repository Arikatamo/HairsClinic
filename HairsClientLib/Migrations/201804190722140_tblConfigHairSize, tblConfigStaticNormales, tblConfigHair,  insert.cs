namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblConfigHairSizetblConfigStaticNormalestblConfigHairinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblConfigHair",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfHaitSizeId = c.Int(nullable: false),
                        ConfStatNormalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblConfigHairSize", t => t.ConfHaitSizeId, cascadeDelete: true)
                .ForeignKey("dbo.tblConfigStaticNormales", t => t.ConfStatNormalId, cascadeDelete: true)
                .Index(t => t.ConfHaitSizeId)
                .Index(t => t.ConfStatNormalId);
            
            CreateTable(
                "dbo.tblConfigStaticNormales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnagenAll = c.Int(nullable: false),
                        TelogenAll = c.Int(nullable: false),
                        AnagenTerm = c.Int(nullable: false),
                        TelogenTerm = c.Int(nullable: false),
                        AnagenVelus = c.Int(nullable: false),
                        TelogenVelus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblConfigHair", "ConfStatNormalId", "dbo.tblConfigStaticNormales");
            DropForeignKey("dbo.tblConfigHair", "ConfHaitSizeId", "dbo.tblConfigHairSize");
            DropIndex("dbo.tblConfigHair", new[] { "ConfStatNormalId" });
            DropIndex("dbo.tblConfigHair", new[] { "ConfHaitSizeId" });
            DropTable("dbo.tblConfigStaticNormales");
            DropTable("dbo.tblConfigHair");
        }
    }
}
