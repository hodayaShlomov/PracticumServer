using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Practicum.Repository.Entities;
using Practicum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Repository.Repositories
{
    internal class PersonRepository : IDataRepository<Person>
    {
        IContext _context;
        public PersonRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Person> AddAsync(Person entity)
        {
            try
            {
               
                if (
                    entity.ParentId == null && _context.People.FirstOrDefault(x => x.IdNumber == entity.IdNumber) != null
                    ||
                    entity.ParentId != null && _context.People.FirstOrDefault(x => x.IdNumber == entity.IdNumber && (x.ParentId == null || x.ParentId == entity.ParentId)) != null
                    )
                {
                 
                    return null;
                }
                EntityEntry<Person> newOne = _context.People.Add(entity);
                await _context.SaveChangesAsync();
                return newOne.Entity;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.People.ToListAsync();
        }
        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.People.FindAsync(id);
        }
    }
}