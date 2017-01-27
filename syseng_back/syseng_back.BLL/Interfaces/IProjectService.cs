using syseng_back.BLL.DTO;
using System;
using System.Collections.Generic;

namespace syseng_back.BLL.Interfaces
{
    public interface IProjectService
    {
        ProjectDTO GetProject(int id);
        IEnumerable<ProjectDTO> GetProjects();
        void AddProject(ProjectDTO project);
        void RemoveProject(int id);
        void UpdateProject(ProjectDTO project);
        void Dispose();
    }
}
