using PMQ.GerenciamentoTarefas.Domain.Enums.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas
{
    public class Tarefa : Entity
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public EPrioridade Prioridade { get; private set; }
        public Etiqueta? Etiquetas { get; private set; }
        public string? EtiquetasId { get; private set; }
        public EStatus Status { get; private set; }

        protected Tarefa()
        {
        }

        public Tarefa(string titulo, string descricao, DateTime dataVencimento, EPrioridade prioridade, Etiqueta? etiquetas, EStatus status)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataVencimento = dataVencimento;
            Prioridade = prioridade;
            Etiquetas = etiquetas;
            Status = status;
        }

        public void Atualizar(string titulo, string descricao, DateTime dataVencimento, EPrioridade prioridade, Etiqueta? etiquetas, EStatus status)
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
