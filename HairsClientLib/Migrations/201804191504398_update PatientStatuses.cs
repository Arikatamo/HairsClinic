namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePatientStatuses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblStatusesForPatient", "PatiendId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblStatusesForPatient", "PatiendId");
        }
    }
}
