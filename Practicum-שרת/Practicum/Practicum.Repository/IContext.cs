using Microsoft.EntityFrameworkCore;
using Practicum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Repository
{
    public interface IContext
    {
        DbSet<HMO> HMOs { get; set; }

        DbSet<Person> People { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
