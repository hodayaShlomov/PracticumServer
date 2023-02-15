using Microsoft.EntityFrameworkCore;
using Practicum.Repository;
using Practicum.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.DBContext
{
    public partial class PracticumContext:DbContext, IContext
    {
        public PracticumContext()
        {

        }
        //
        public PracticumContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<HMO> HMOs  { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localDb)\msSQlLocalDb;database=PracticumProject;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelbulider)
        {
            base.OnModelCreating(modelbulider);
        }
    }
}
