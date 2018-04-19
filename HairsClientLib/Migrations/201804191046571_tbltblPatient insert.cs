namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbltblPatientinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPatient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 2000),
                        PhotosId = c.Int(nullable: false),
                        DateNextVisit = c.DateTime(nullable: false),
                        TimeNextVisit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblContscts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.tblStatusesForPatient", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.StatusId);
            
            AddColumn("dbo.tblPhotoses", "Patient_Id", c => c.Int());
            CreateIndex("dbo.tblPhotoses", "Patient_Id");
            AddForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPatient", "StatusId", "dbo.tblStatusesForPatient");
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropForeignKey("dbo.tblPatient", "ContactId", "dbo.tblContscts");
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            DropIndex("dbo.tblPatient", new[] { "StatusId" });
            DropIndex("dbo.tblPatient", new[] { "ContactId" });
            DropColumn("dbo.tblPhotoses", "Patient_Id");
            DropTable("dbo.tblPatient");
        }
    }
}
