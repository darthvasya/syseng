using System;
using System.Collections.Generic;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using syseng_back.DAL.EF;
using System.Data.Entity;

namespace syseng_back.DAL.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        private ApplicationContext _context;

        public ProjectRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(Project item)
        {
            _context.Projects.Add(item);
        }

        public void Delete(int id)
        {
            Project project = _context.Projects.Find(id);
            if (project != null)
                _context.Projects.Remove(project);
        }

        public Project Get(int id)
        {
            return _context.Projects.Find(id);
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects;
        }

        public void Update(Project item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
