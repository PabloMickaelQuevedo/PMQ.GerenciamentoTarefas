using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Context
{
    public class Context : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;

        public Context(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            _configuration = configuration;
            _loggerFactory = loggerFactory;
        }

        public DbSet<Tarefa> Tarefa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory);

            optionsBuilder.UseOracle(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Model.SetMaxIdentifierLength(30);

            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<ValidationFailure>();
        }
    }
}
