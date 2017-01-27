using AutoMapper;
using syseng_back.BLL.DTO;
using syseng_back.BLL.Infrastructure;
using syseng_back.BLL.Interfaces;
using syseng_back.DAL.Entities;
using syseng_back.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace syseng_back.BLL.Services
{
    public class ProjectService : IProjectService
    {
        IUnitOfWork _context { get; set; }

        public ProjectService(IUnitOfWork uow)
        {
            _context = uow;
        }

        public void AddProject(ProjectDTO project)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ProjectDTO GetProject(int id)
        {
            var project = _context.Projects.Get(id);
            Mapper.Initialize(c => c.CreateMap<Project, ProjectDTO>());
            return Mapper.Map<Project, ProjectDTO>(project);
        }

        public IEnumerable<ProjectDTO> GetProjects()
        {
            Mapper.Initialize(c => c.CreateMap<Project, ProjectDTO>());
            return Mapper.Map<IEnumerable<Project>, List<ProjectDTO>>(_context.Projects.GetAll());
        }

        public void RemoveProject(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(ProjectDTO project)
        {
            throw new NotImplementedException();
        }


    }
}
