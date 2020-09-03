using LubyDesafio.Services.Interfaces;
using LubyDesafio.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LubyDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeEntryController : ControllerBase
    {
        private readonly ITimeEntryService _timeEntryService;

        public TimeEntryController(ITimeEntryService timeEntryService)
        {
            _timeEntryService = timeEntryService;
        }
        [HttpPost]
        public IActionResult Create(TImeEntryViewModel developerViewModel)
        {
            _timeEntryService.Add(developerViewModel);

            return Ok();
        }
    }
}
