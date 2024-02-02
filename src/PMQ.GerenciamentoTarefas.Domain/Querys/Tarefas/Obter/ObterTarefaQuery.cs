using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Querys.Tarefas.Obter
{
    public class ObterTarefaQuery : IRequest<Tarefa?>
    {
        public string Id { get; private set; }

        public ObterTarefaQuery(string id)
        {
            Id = id;
        }
    }
}
