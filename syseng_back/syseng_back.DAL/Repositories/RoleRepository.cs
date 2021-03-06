﻿using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

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
            _context.Roles.Add(item);
        }

        public void Delete(int id)
        {
            Role role = _context.Roles.Find(id);
            if (role != null)
                _context.Roles.Remove(role);
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
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
