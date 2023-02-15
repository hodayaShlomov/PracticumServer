using AutoMapper;
using Practicum.Common.DTOs;
using Practicum.Repository.Entities;
using Practicum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Services.Services
{
    internal class PersonService : IDataService<PersonDTO>
    {
        private readonly IDataRepository<Person> _person;
        private readonly IMapper _mapper;

        public PersonService(IDataRepository<Person> person, IMapper mapper)
        {
            _person = person;
            _mapper = mapper;
        }

        public async Task<PersonDTO> AddAsync(PersonDTO entity)
        {
            return _mapper.Map<PersonDTO>(await _person.AddAsync(_mapper.Map<Person>(entity)));
        }

        public async Task<List<PersonDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PersonDTO>>(await _person.GetAllAsync());
        }

        public async Task<PersonDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<PersonDTO>(await _person.GetByIdAsync(id));
        }
    }
    }
