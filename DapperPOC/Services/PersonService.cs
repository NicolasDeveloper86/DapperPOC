using Common.DTOs;
using Common.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperPOC.Services
{
    public class PersonService : IPersonService
    {
        public Task<List<PersonDto>> GetPersons(PersonFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
