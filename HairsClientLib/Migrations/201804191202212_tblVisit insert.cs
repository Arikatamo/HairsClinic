namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblVisitinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblVisit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CommentaryId = c.Int(nullable: false),
                        ResearchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblPatient", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            AddColumn("dbo.tblCommentaryToVisit", "Visit_Id", c => c.Int());
            AddColumn("dbo.tblResearch", "Visit_Id", c => c.Int());
            AddColumn("dbo.tblUser", "Visit_Id", c => c.Int());
            CreateIndex("dbo.tblCommentaryToVisit", "Visit_Id");
            CreateIndex("dbo.tblResearch", "Visit_Id");
            CreateIndex("dbo.tblUser", "Visit_Id");
            AddForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit", "Id");
            AddForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit", "Id");
            AddForeignKey("dbo.tblUser", "Visit_Id", "dbo.tblVisit", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblVisit", "PatientId", "dbo.tblPatient");
            DropForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit");
            DropIndex("dbo.tblVisit", new[] { "PatientId" });
            DropIndex("dbo.tblUser", new[] { "Visit_Id" });
            DropIndex("dbo.tblResearch", new[] { "Visit_Id" });
            DropIndex("dbo.tblCommentaryToVisit", new[] { "Visit_Id" });
            DropColumn("dbo.tblUser", "Visit_Id");
            DropColumn("dbo.tblResearch", "Visit_Id");
            DropColumn("dbo.tblCommentaryToVisit", "Visit_Id");
            DropTable("dbo.tblVisit");
        }
    }
}
