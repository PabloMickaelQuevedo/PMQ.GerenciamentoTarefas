using Microsoft.Extensions.DependencyInjection;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;
using PMQ.GerenciamentoTarefas.Infra.Data.Context;
using PMQ.GerenciamentoTarefas.Infra.Data.Repositories;
using PMQ.GerenciamentoTarefas.Infra.Data.UoW;

namespace PMQ.GerencimanetoTarefas.Infra.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            // Domain Services

            // Repositories 
            services.AddScoped<ITarefaRepository, TarefaRepository>();

            // Database Contexts
            services.AddDbContext<TarefaContext>();

            // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
