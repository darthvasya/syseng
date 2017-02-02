using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

namespace syseng_back.DAL.Repositories
{
    public class LeadRepository : IRepository<Lead>
    {
        private ApplicationContext _context;

        public LeadRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(Lead item)
        {
            _context.Leads.Add(item);
        }

        public void Delete(int id)
        {
            Lead lead = _context.Leads.Find(id);
            if (lead != null)
                _context.Leads.Remove(lead);
        }

        public Lead Get(int id)
        {
            return _context.Leads.Find(id);
        }

        public IEnumerable<Lead> GetAll()
        {
            return _context.Leads;
        }

        public void Update(Lead item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
