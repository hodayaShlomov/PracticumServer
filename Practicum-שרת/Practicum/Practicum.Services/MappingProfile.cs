using AutoMapper;
using Practicum.Common.DTOs;
using Practicum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HMO, HMO_DTO>().ReverseMap();
            CreateMap<Person, PersonDTO>().ReverseMap();
        }
    }
}
