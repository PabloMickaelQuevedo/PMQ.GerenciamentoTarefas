using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Enums.Tarefas;

namespace PMQ.GerenciamentoTarefas.Models.Tarefas.Listar
{
    public class ListarTarefaResponse
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiqueta? Etiquetas { get; set; }
        public string? EtiquetasId { get; set; }
        public EStatus Status { get; set; }

        public static IEnumerable<ListarTarefaResponse?> Map(IEnumerable<Tarefa> tarefas)
        {
            return tarefas.Select(Map) ?? Enumerable.Empty<ListarTarefaResponse>();
        }

        internal static ListarTarefaResponse? Map(Tarefa tarefa)
        {
            return tarefa is null ? default : new ListarTarefaResponse()
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
