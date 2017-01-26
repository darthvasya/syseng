using syseng_back.DAL.EF;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syseng_back.DAL.Repositories
{
    public class RoleRepository : IRepository<Role>
    {
        private ApplicationContext _context;

        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(Role item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Role Get(int id)
        {
            return _context.Roles.Find(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles;
        }

        public void Update(Role item)
        {
            throw new NotImplementedException();
        }
    }
}
