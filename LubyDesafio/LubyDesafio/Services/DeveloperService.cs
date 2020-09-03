using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entidades;
using LubyDesafio.Services.Interfaces;
using LubyDesafio.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LubyDesafio.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository _developerRepository;



        public DeveloperService(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }
        public void Add(DeveloperViewModel developerViewModel)
        {
            var developer = new Developer(developerViewModel.Name, developerViewModel.Age, developerViewModel.LinkedinURL);

            _developerRepository.Add(developer);
        }

        public bool Delete(Guid id)
        {
            var developer = GetById(id);
            if (developer != null)
            {
                _developerRepository.Delete(id);
                return true;
            }
            return false;
        }

        public IEnumerable<DeveloperViewModel> GetAll()
        {
            var developers = _developerRepository.GetAll();

            var developersViewModel = new List<DeveloperViewModel>();

            foreach (var item in developers)
                developersViewModel.Add(MappingEntityToViewModel(item));

            return developersViewModel;
        }

        public DeveloperViewModel GetById(Guid id)
        {

            var developer = _developerRepository.GetById(id);
            return MappingEntityToViewModel(developer);
        }


        public bool Update(DeveloperViewModel developerViewModel)
        {
            var developerDb = _developerRepository.GetById(developerViewModel.Id.Value);

            MappingViewlModelToEntity(developerViewModel, developerDb);

            if (developerDb != null)
            {
                _developerRepository.Update(developerDb);
                return true;
            }
            return false;
        }

        private static void MappingViewlModelToEntity(DeveloperViewModel developerViewModel, Developer developerDb)
        {
            developerDb.Age = developerViewModel.Age;
            developerDb.Name = developerViewModel.Name;
            developerDb.LinkedinURL = developerViewModel.LinkedinURL;
        }


        private static DeveloperViewModel MappingEntityToViewModel(Developer developer)
        {
            return new DeveloperViewModel
            {
                Id = developer.Id,
                Name = developer.Name,
                LinkedinURL = developer.LinkedinURL,
                Age = developer.Age
            };
        }

        public List<DeveloperHoursWorkedViewModel> GetDeveloperWithHours()
        {
            var developersDb = _developerRepository.GetAllWithHours();

            var developersModel = new List<DeveloperHoursWorkedViewModel>();

            foreach (var item in developersDb)
            {
                var hours = item.TimeEntries.Sum(x => x.TotalHours);
                developersModel.Add(new DeveloperHoursWorkedViewModel
                {
                    Name = item.Name,
                    TotalHourPerWeek = hours
                });
            }

            var result = developersModel.OrderByDescending(x => x.TotalHourPerWeek).Take(5).ToList();

            return result;
        }
    }
}
