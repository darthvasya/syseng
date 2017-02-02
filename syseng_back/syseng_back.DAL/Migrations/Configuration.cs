namespace syseng_back.DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<syseng_back.DAL.EF.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(syseng_back.DAL.EF.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Leads.AddOrUpdate(
                  p => p.Name,
                  new Lead { Name = "Andrew Peters", Body = "s", Date = DateTime.Now, Email = "s" },
                  new Lead { Name = "Brice Lambson", Body = "s", Date = DateTime.Now, Email = "s" },
                  new Lead { Name = "Rowan Miller", Body = "s", Date = DateTime.Now, Email = "s" }
                );
            //
        }
    }
}
