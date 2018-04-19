namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblResearchStatustblDiagnosestblObjectivestblConfigHairSizeinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblConfigHairSize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TelogenHairLong = c.Short(nullable: false),
                        Diametr_Velus_Terminale = c.Short(nullable: false),
                        Diametr_Terminale_S_M = c.Short(nullable: false),
                        Diametr_Terminale_M_B = c.Short(nullable: false),
                        Radius_Folikular_Unit = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblDiagnoses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Diagnos = c.String(nullable: false, maxLength: 2000),
                        BeginDate = c.DateTime(nullable: false),
                        DateOfLastConfirm = c.DateTime(nullable: false),
                        Commentary = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblObjectives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameObjectiv = c.String(nullable: false, maxLength: 50),
                        Scale = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblResearchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblResearchStatus");
            DropTable("dbo.tblObjectives");
            DropTable("dbo.tblDiagnoses");
            DropTable("dbo.tblConfigHairSize");
        }
    }
}
