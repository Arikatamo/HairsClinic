namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetblPatientStatuses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblPatientStatus", "StatusID", "dbo.tblStatusesForPatient");
            DropIndex("dbo.tblPatientStatus", new[] { "StatusID" });
            DropTable("dbo.tblPatientStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblPatientStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.tblPatientStatus", "StatusID");
            AddForeignKey("dbo.tblPatientStatus", "StatusID", "dbo.tblStatusesForPatient", "Id", cascadeDelete: true);
        }
    }
}
