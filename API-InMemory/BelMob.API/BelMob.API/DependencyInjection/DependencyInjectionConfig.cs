using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Servicos;
using BelMob.Infrastructure.Contexts;
using BelMob.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BelMob.API.DependencyInjection
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveApiDependencies(this IServiceCollection services)
        {
            services.AddDbContext<SistemaContext>(opt => opt.UseInMemoryDatabase("BelMob"));

            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IProfissionalService, ProfissionalService>();
            services.AddTransient<IProfissionalRepository, ProfissionalRepository>();
            services.AddTransient<IAgendamentoService, AgendamentoService>();
            services.AddTransient<IAgendamentoRepository, AgendamentoRepository>();

            return services;
        }
    }
}
