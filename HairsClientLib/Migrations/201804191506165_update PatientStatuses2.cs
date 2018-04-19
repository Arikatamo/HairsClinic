namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePatientStatuses2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblPatient", "StatusId", "dbo.tblStatusesForPatient");
            DropIndex("dbo.tblPatient", new[] { "StatusId" });
            RenameColumn(table: "dbo.tblPatient", name: "StatusId", newName: "StatusesForPatient_Id");
            AlterColumn("dbo.tblPatient", "StatusesForPatient_Id", c => c.Int());
            CreateIndex("dbo.tblPatient", "StatusesForPatient_Id");
            AddForeignKey("dbo.tblPatient", "StatusesForPatient_Id", "dbo.tblStatusesForPatient", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPatient", "StatusesForPatient_Id", "dbo.tblStatusesForPatient");
            DropIndex("dbo.tblPatient", new[] { "StatusesForPatient_Id" });
            AlterColumn("dbo.tblPatient", "StatusesForPatient_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblPatient", name: "StatusesForPatient_Id", newName: "StatusId");
            CreateIndex("dbo.tblPatient", "StatusId");
            AddForeignKey("dbo.tblPatient", "StatusId", "dbo.tblStatusesForPatient", "Id", cascadeDelete: true);
        }
    }
}
