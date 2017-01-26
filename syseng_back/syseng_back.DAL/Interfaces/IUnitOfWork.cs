using syseng_back.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Role> Roles { get; }
        IRepository<Article> Articles { get; }
        IRepository<Project> Projects { get; }
        IRepository<ProjectType> ProjectTypes { get; }
        void Save();
    }
}
