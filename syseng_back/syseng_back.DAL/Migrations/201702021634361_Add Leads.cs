namespace syseng_back.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLeads : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Body = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leads");
        }
    }
}
