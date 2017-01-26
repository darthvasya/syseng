using System;
using syseng_back.DAL.EF;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.Entities;

namespace syseng_back.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private UserRepository userRepository;
        private RoleRepository roleRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
        }

        public IRepository<Role> Roles
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(db);
                return roleRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
