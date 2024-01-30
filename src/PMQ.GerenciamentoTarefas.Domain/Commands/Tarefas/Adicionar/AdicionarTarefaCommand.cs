using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Enums.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Adicionar
{
    public class AdicionarTarefaCommand : IRequest<string>
    {
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiqueta? Etiquetas { get; set; }
        public string? EtiquetasId { get; set; }
        public EStatus Status { get; set; }
    }
}
