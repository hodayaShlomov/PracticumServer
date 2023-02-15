using Microsoft.Extensions.DependencyInjection;
using Practicum.Repository.Entities;
using Practicum.Repository.Interface;
using Practicum.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Repository
{
    public static class ServiceCollectionExtention
    {
        public static void AddRepositoriesServices(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<HMO>, HMORepository>();
            services.AddScoped<IDataRepository<Person>, PersonRepository>();
        }
    }
}
