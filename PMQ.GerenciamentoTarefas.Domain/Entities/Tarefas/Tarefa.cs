using PMQ.GerenciamentoTarefas.Domain.Enuns.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.ValueObjects;

namespace PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas
{
    public class Tarefa
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public EPrioridade Prioridade { get; set; }
        public Etiquetas Etiquetas { get; set; }
        public EStatus Status { get; set; }
    }
}
