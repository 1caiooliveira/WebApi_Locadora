using Locadora.Business.Interfaces;
using Locadora.Business.Notificacoes;
using Locadora.Business.Services;
using Locadora.Data.Context;
using Locadora.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiLocadora.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<ILocacaoRepository, LocacaoRepository>();

            services.AddScoped<INotificador, Notificador>();

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<ILocacaoService, LocacaoService>();
            
            return services;

        }
    }
}
