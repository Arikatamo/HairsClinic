namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblCommentaryTypeandtblCommentaryToVisitupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCommentaryToVisit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentaryTypeId = c.Int(nullable: false),
                        Commentary = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCommentaryType", t => t.CommentaryTypeId, cascadeDelete: true)
                .Index(t => t.CommentaryTypeId);
            
            CreateTable(
                "dbo.tblCommentaryType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToPatient = c.String(),
                        ToAdministrator = c.String(),
                        DoctorToPatient = c.String(),
                        AdministratorToHimselt = c.String(),
                        DoctorToHimSelf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblCommentaryToVisit", "CommentaryTypeId", "dbo.tblCommentaryType");
            DropIndex("dbo.tblCommentaryToVisit", new[] { "CommentaryTypeId" });
            DropTable("dbo.tblCommentaryType");
            DropTable("dbo.tblCommentaryToVisit");
        }
    }
}
