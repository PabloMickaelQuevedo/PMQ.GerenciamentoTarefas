using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Infra.Data.Context.Mappers;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Context
{
    public class TarefaContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;

        public TarefaContext(DbContextOptions<TarefaContext> options, IConfiguration configuration, ILoggerFactory loggerFactory)
        : base(options)
        {
            _configuration = configuration;
            _loggerFactory = loggerFactory;
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(_configuration.GetConnectionString("DefaultConnection"));

            optionsBuilder.EnableDetailedErrors().UseLoggerFactory(_loggerFactory);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Model.SetMaxIdentifierLength(30);

            modelBuilder.ApplyConfiguration(new TarefaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());

            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<ValidationFailure>();
        }
    }
}
