namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblContactsupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblContscts", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.tblContscts", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.tblContscts", "Email", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.tblContscts", "Adress", c => c.String(nullable: false, maxLength: 300));
            AddColumn("dbo.tblContscts", "Post", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.tblContscts", "Speciality", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.tblContscts", "Education", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.tblContscts", "Commentary", c => c.String(nullable: false, maxLength: 1000));
            AddColumn("dbo.tblContscts", "Grade", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblContscts", "Grade");
            DropColumn("dbo.tblContscts", "Commentary");
            DropColumn("dbo.tblContscts", "Education");
            DropColumn("dbo.tblContscts", "Speciality");
            DropColumn("dbo.tblContscts", "Post");
            DropColumn("dbo.tblContscts", "Adress");
            DropColumn("dbo.tblContscts", "Email");
            DropColumn("dbo.tblContscts", "Phone");
            DropColumn("dbo.tblContscts", "DateOfBirth");
        }
    }
}
