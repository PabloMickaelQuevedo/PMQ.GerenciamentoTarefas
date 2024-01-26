using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Enuns.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Adicionar
{
    public class AdicionarTarefaCommand : IRequest<string>
    {
        public string Titulo { get; private set; }
        public string? Descricao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public EPrioridade Prioridade { get; private set; }
        public Etiqueta? Etiquetas { get; private set; }
        public string? EtiquetasId { get; private set; }
        public EStatus Status { get; private set; }

        public AdicionarTarefaCommand(
            string titulo,
            string descricao,
            DateTime dataVencimento,
            EPrioridade prioridade,
            Etiqueta etiquetas,
            EStatus status)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Etiquetas = etiquetas;
            Status = status;
        }
    }
}
