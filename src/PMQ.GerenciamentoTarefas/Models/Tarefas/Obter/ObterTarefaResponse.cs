using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Enuns.Tarefas;

namespace PMQ.GerenciamentoTarefas.Models.Tarefas.Obter
{
    public class ObterTarefaResponse
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiqueta? Etiquetas { get; set; }
        public string? EtiquetasId { get; set; }
        public EStatus Status { get; set; }

        public static ObterTarefaResponse? Map(Tarefa? tarefa)
        {
            return tarefa is null ? default : new ObterTarefaResponse()
            {
                Id = tarefa.Id,
                Titulo = tarefa.Titulo,
                Descricao = tarefa.Descricao,
                DataVencimento = tarefa.DataVencimento,
                Prioridade = tarefa.Prioridade,
                Etiquetas = tarefa.Etiquetas,
                EtiquetasId = tarefa.EtiquetasId,
                Status = tarefa.Status
            };
        }
    }
}
