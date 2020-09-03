using LubyDesafio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Services.Interfaces
{
    public interface IProjectService
    {
        void Add(ProjectViewModel projectViewModel);

        IEnumerable<ProjectViewModel> GetAll();

        bool Update(ProjectViewModel projectViewModel);

        ProjectViewModel GetById(Guid id);

        bool Delete(Guid id);
    }
}
