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
            builder.Property(t => t.Titulo).HasColumnName("TITULO").HasMaxLength(100).IsRequired();
            builder.Property(t => t.Descricao).HasColumnName("DESCRICAO").HasMaxLength(500);
            builder.Property(t => t.DataVencimento).HasColumnName("DATA_VENCIMENTO").IsRequired();
            builder.Property(t => t.Prioridade).HasColumnName("PRIORIDADE").IsRequired();
            builder.Property(t => t.Etiquetas).HasColumnName("ETIQUETAS").HasMaxLength(100);
            builder.Property(t => t.Status).HasColumnName("STATUS").IsRequired();
        }
    }
}
