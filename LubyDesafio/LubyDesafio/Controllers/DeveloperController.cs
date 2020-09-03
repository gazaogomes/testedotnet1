using LubyDesafio.Entidades;
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
    public class DeveloperController : ControllerBase
    {
        public readonly IDeveloperService _developerService;


        public DeveloperController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        [HttpGet]
        [Route("developerId:guid")]
        public IActionResult GetById(Guid developerId)
        {
            return Ok(_developerService.GetById(developerId));
        }

        [HttpGet]
        [Route("worked")]
        public IActionResult GetHoursWorked(Guid developerId)
        {
            return Ok(_developerService.GetDeveloperWithHours());
        }

        [HttpPut]
        public IActionResult Update(DeveloperViewModel developerViewModel)
        {
            return Ok(_developerService.Update(developerViewModel));
        }

        [HttpPost]
        public IActionResult Create(DeveloperViewModel developerViewModel)
        {
            _developerService.Add(developerViewModel);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_developerService.GetAll());
        }

        [HttpDelete]
        
        public IActionResult Delete(Guid id)
        {
            return Ok(_developerService.Delete(id));
        }

    }


}
