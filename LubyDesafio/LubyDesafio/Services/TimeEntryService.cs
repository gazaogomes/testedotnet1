using LubyDesafio.Data.Repositories.Interfaces;
using LubyDesafio.Entities;
using LubyDesafio.Services.Interfaces;
using LubyDesafio.ViewModel;
using System;

namespace LubyDesafio.Services
{
    public class TimeEntryService : ITimeEntryService
    {
        private readonly ITimeEntryRepository _timeEntryRepository;
        private readonly IDeveloperRepository _developerRepository;

        public TimeEntryService(ITimeEntryRepository timeEntryRepository, IDeveloperRepository developerRepository)
        {
            _timeEntryRepository = timeEntryRepository;
            _developerRepository = developerRepository;
        }

        public IDeveloperRepository DeveloperRepository { get; }

        public void Add(TImeEntryViewModel developerViewModel)
        {
            

            var dateBegin = developerViewModel.DateBegin.ToString("yyyy-MM-dd HH:mm:ss");
            var dateEnd = developerViewModel.DateEnd.ToString("yyyy-MM-dd HH:mm:ss");

            
            var stamp = developerViewModel.DateEnd.Subtract(developerViewModel.DateBegin);
            var hourDays = TimeSpan.FromHours(stamp.TotalDays).TotalHours;
            var hourMinute = TimeSpan.FromMinutes(stamp.TotalMinutes).TotalHours;
            var hourSecond = TimeSpan.FromSeconds(stamp.TotalSeconds).TotalHours;
           

            var totalHour = (hourDays * 24) + (hourMinute / 60)  + (hourSecond/ 36000) ;


            var timeEntry = new TimeEntry(Convert.ToDateTime(dateBegin), Convert.ToDateTime(dateEnd), developerViewModel.DeveloperId, totalHour);

            _timeEntryRepository.Add(timeEntry);

        }
    }
}
