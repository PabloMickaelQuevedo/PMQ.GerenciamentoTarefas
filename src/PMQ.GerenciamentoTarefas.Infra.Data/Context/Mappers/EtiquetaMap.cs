using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Context.Mappers
{
    public class EtiquetaMap : IEntityTypeConfiguration<Etiqueta>
    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("ETIQUETA");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("ID").IsRequired();
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
        }
    }
}
