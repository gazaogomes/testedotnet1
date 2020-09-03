using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entities;
using LubyDesafio.Services.Interfaces;
using LubyDesafio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public void Add(ProjectViewModel projectViewModel)
        {
            var project = new Project(projectViewModel.Name);

            _projectRepository.Add(project);
        }

        public bool Delete(Guid id)
        {
            var project = _projectRepository.GetById(id);
            if (project != null)
            {
                _projectRepository.Delete(id);
                return true;
            }
            return false;
        }
        public IEnumerable<ProjectViewModel> GetAll()
        {
            var projects = _projectRepository.GetAll();

            var projectsViewModel = new List<ProjectViewModel>();

            foreach (var item in projects)
                projectsViewModel.Add(MappingEntityToViewModel(item));

            return projectsViewModel;
        }

        private ProjectViewModel MappingEntityToViewModel(Project item)
        {
            return new ProjectViewModel
            {
                Id = item.Id,
                Name = item.Name
            };
        }

        public ProjectViewModel GetById(Guid id)
        {
            var project = _projectRepository.GetById(id);
            return MappingEntityToViewModel(project);
        }


        public bool Update(ProjectViewModel projectViewModel )
        {
            var projectDb = _projectRepository.GetById(projectViewModel.Id.Value);

            MappingViewlModelToEntity(projectViewModel, projectDb);

            if (projectDb != null)
            {
                _projectRepository.Update(projectDb);
                return true;
            }
            return false;
        }

        private void MappingViewlModelToEntity(ProjectViewModel projectViewModel, Project projectDb)
        {
            projectDb.Name = projectViewModel.Name;
        }
    }
}
