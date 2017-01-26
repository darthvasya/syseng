namespace syseng_back.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Next : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                        CountView = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ImageUrl = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                        CountView = c.Int(nullable: false),
                        Customer = c.String(),
                        CustomerUrl = c.String(),
                        ProjectTypeId = c.Int(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectTypeId, cascadeDelete: true)
                .Index(t => t.ProjectTypeId)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjectTypeId", "dbo.ProjectTypes");
            DropForeignKey("dbo.Projects", "AuthorId", "dbo.Users");
            DropForeignKey("dbo.Articles", "AuthorId", "dbo.Users");
            DropIndex("dbo.Projects", new[] { "AuthorId" });
            DropIndex("dbo.Projects", new[] { "ProjectTypeId" });
            DropIndex("dbo.Articles", new[] { "AuthorId" });
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.Projects");
            DropTable("dbo.Articles");
        }
    }
}
