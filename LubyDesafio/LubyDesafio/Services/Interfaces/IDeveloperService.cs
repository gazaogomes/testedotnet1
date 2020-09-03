using LubyDesafio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Services.Interfaces
{
    public interface IDeveloperService
    {
        void Add(DeveloperViewModel developerViewModel);

        IEnumerable<DeveloperViewModel> GetAll();

        bool Update(DeveloperViewModel developerViewModel);

        DeveloperViewModel GetById(Guid id);

        bool Delete(Guid id);

        List<DeveloperHoursWorkedViewModel> GetDeveloperWithHours();
    }
}
