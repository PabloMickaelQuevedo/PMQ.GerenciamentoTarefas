using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Context.Mappers
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("ID").IsRequired();
        }
    }
}
