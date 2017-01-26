using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

namespace syseng_back.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(User item)
        {
            _context.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = _context.Users.Find(id);
            if (user != null)
                _context.Users.Remove(user);
        }

        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Update(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
