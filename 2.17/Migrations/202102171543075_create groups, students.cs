namespace _2._17.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creategroupsstudents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Students", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropTable("dbo.Groups");
            DropTable("dbo.Students");
        }
    }
}
