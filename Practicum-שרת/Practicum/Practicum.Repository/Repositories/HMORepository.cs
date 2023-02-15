using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Practicum.Repository.Entities;
using Practicum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Repository.Repositories
{
    internal class HMORepository:IDataRepository<HMO>
    {
        IContext _context;

        public HMORepository(IContext context)
        {
            _context = context;
        }

        public async Task<HMO> AddAsync(HMO entity)
        {
            EntityEntry<HMO> newOne = _context.HMOs.Add(entity);
            await _context.SaveChangesAsync();
            return newOne.Entity;

        }
        public async Task<List<HMO>> GetAllAsync()
        {
            return await _context.HMOs.ToListAsync();
        }

        public async Task<HMO> GetByIdAsync(int id)
        {
            return await _context.HMOs.FindAsync(id);
        }
    }
}
