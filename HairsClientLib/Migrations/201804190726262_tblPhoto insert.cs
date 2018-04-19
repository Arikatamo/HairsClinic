namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblPhotoinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPhotoses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfCreate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Photo = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblPhotoses");
        }
    }
}
