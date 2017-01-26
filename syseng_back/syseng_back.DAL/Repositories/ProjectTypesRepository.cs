using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

namespace syseng_back.DAL.Repositories
{
    public class ProjectTypesRepository : IRepository<ProjectType>
    {
        private ApplicationContext _context;

        public ProjectTypesRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(ProjectType item)
        {
            _context.ProjectTypes.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProjectType Get(int id)
        {
            return _context.ProjectTypes.Find(id);
        }

        public IEnumerable<ProjectType> GetAll()
        {
            return _context.ProjectTypes;
        }

        public void Update(ProjectType item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
