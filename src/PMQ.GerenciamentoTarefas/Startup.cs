using Microsoft.AspNetCore.Mvc;
using PMQ.GerencimanetoTarefas.Infra.CrossCutting.Ioc;

namespace PMQ.GerenciamentoTarefas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public readonly IConfiguration Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Configuração para não retornar o erro de validação do FluentValidation
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            MediatorInjection.AddMediator(services);
            DependencyInjection.AddServices(services);
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
