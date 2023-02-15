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
    internal class HMOService : IDataService<HMO_DTO>
    {
        private readonly IDataRepository<HMO> _HMO;
        private readonly IMapper _mapper;

        public HMOService(IDataRepository<HMO> HMO, IMapper mapper)
        {
            _HMO = HMO;
            _mapper = mapper;
        }

        public async Task<HMO_DTO> AddAsync(HMO_DTO entity)
        {
            return _mapper.Map<HMO_DTO>(await _HMO.AddAsync(_mapper.Map<HMO>(entity)));
        }

        public async Task<List<HMO_DTO>> GetAllAsync()
        {
            return _mapper.Map<List<HMO_DTO>>(await _HMO.GetAllAsync());
        }

        public async Task<HMO_DTO> GetByIdAsync(int id)
        {
            return _mapper.Map<HMO_DTO>(await _HMO.GetByIdAsync(id));
        }
    }
}
