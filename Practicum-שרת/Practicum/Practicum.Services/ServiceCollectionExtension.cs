using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practicum.Common.DTOs;
using Practicum.DBContext;
using Practicum.Repository;
using Practicum.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositoriesServices();
            services.AddScoped<IDataService<PersonDTO>, PersonService>();
            services.AddScoped<IDataService<HMO_DTO>, HMOService>();
            IServiceCollection serviceCollection = services.AddTransient<IContext, PracticumContext>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
