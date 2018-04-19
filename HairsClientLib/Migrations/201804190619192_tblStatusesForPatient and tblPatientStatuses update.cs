namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblStatusesForPatientandtblPatientStatusesupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPatientStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblStatusesForPatient", t => t.StatusID, cascadeDelete: true)
                .Index(t => t.StatusID);
            
            CreateTable(
                "dbo.tblStatusesForPatient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPatientStatus", "StatusID", "dbo.tblStatusesForPatient");
            DropIndex("dbo.tblPatientStatus", new[] { "StatusID" });
            DropTable("dbo.tblStatusesForPatient");
            DropTable("dbo.tblPatientStatus");
        }
    }
}
