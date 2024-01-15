using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Infra.Data.UoW;

namespace PMQ.GerencimanetoTarefas.Infra.CrossCutting.Ioc
{
    public class DependencyInjection
    {
        public static void AddServices(IServiceCollection services)
        {
            // Domain Services

            // Repositories 
            // service.AddScoped<IRepository, Repository>();

            // Database Contexts
            services.AddDbContext<DbContext>();

            // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
