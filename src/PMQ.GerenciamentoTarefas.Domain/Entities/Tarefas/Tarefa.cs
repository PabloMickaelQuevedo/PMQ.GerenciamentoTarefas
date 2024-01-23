using PMQ.GerenciamentoTarefas.Domain.Enuns.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas
{
    public class Tarefa
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiqueta? Etiquetas { get; set; }
        public string? EtiquetasId { get; set; }
        public EStatus Status { get; set; }

        protected Tarefa()
        {
        }

        public Tarefa(string titulo, string descricao, DateTime dataVencimento, EPrioridade prioridade, Etiqueta etiquetas, EStatus status)
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
