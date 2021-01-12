using Common.DTOs;
using Common.Filters;
using DapperPOC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperPOC.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [Route("api/contacts")]
        [HttpGet]
        public async Task<List<PersonDto>> GetPersonDtos([FromBody] PersonFilter filter)
        {
            return await _personService.GetPersons(filter);
        }
    }
}
