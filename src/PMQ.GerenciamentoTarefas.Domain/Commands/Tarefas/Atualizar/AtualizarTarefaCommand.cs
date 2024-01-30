using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Enums.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Atualizar
{
    public class AtualizarTarefaCommand : IRequest<Unit>
    {
        public string Id { get; private set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiqueta? Etiquetas { get; set; }
        public string? EtiquetasId { get; set; }
        public EStatus Status { get; set; }

        public void AtribuirId(string id)
        {
            Id = id;
        }
    }
}
