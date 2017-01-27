namespace syseng_back.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shortbody : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ShortBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "ShortBody");
        }
    }
}
