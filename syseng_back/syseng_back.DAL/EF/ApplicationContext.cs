using syseng_back.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }

        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new StoreDbInitializer());
        }

        public ApplicationContext(string connectionString)
            :base(connectionString)
        {
        }

        public ApplicationContext()
        {

        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
        {
            protected override void Seed(ApplicationContext db)
            {
                db.Users.Add(new User { Email = "v@mail.ru", Password = "123456", RoleId = 1 });
                db.Users.Add(new User { Email = "n@mail.ru", Password = "123456", RoleId = 1 });
                db.SaveChanges();
            }
        }
    }
}
