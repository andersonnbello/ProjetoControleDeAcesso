using Controle_Acesso_Predio.Application.Mappings;
using Controle_Acesso_Predio.Application.Services;
using Controle_Acesso_Predio.Application.Services.Interfaces;
using Controle_Acesso_Predio.Data.Context;
using Controle_Acesso_Predio.Data.Repositories;
using Controle_Acesso_Predio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Controle_Acesso_Predio.CrossCutting.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyContext>(op => op.UseSqlServer(configuration.GetConnectionString("ControleAcessoPredio")));

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IControlPersonRepository, ControlPersonRepository>();
            

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IControlPersonService, ControlPersonService>();

            services.AddAutoMapper(typeof(DomainToDTOMappings));

            return services;
        }
    }
}
