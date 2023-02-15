using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Practicum.Common.DTOs;
using Practicum.Services;

namespace Practicum.WebAPI.Controllers
{
    [EnableCors()]
    [Route("api/[controller]")]
    [ApiController]
    public class HMOController : Controller
    {
        private readonly IDataService<HMO_DTO> _HMO;

        public HMOController(IDataService<HMO_DTO> HMO)
        {
            _HMO = HMO;
        }

        [HttpGet]
        public async Task<List<HMO_DTO>> GetHMO()
        {
            return await _HMO.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<HMO_DTO> GetHMO(int id)
        {
            return await _HMO.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<HMO_DTO> Post([FromBody] HMO_DTO HMO)
        {
            return await _HMO.AddAsync(HMO);
        }
    }
}
