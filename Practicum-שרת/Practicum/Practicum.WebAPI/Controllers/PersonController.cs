using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Practicum.Common.DTOs;
using Practicum.Services;

namespace Practicum.WebAPI.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IDataService<PersonDTO> _person;

        public PersonController(IDataService<PersonDTO> person)
        {
            _person = person;
        }
        [HttpGet]
        public async Task<List<PersonDTO>> GetPerson()
        {
            return await _person.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> GetPerson(int id)
        {
            return await _person.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<PersonDTO> Post([FromBody] PersonDTO ambulance)
        {
            return await _person.AddAsync(ambulance);
        }
    }
}
