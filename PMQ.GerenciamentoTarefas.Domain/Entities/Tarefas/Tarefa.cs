using PMQ.GerenciamentoTarefas.Domain.Enuns.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.ValueObjects;

namespace PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiquetas? Etiquetas { get; set; }
        public EStatus Status { get; set; }

        public Tarefa(string titulo, string descricao, DateTime dataVencimento, EPrioridade prioridade, Etiquetas etiquetas, EStatus status)
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
