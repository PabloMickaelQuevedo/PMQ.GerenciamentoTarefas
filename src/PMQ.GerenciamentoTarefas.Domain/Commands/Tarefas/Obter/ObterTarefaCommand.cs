using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Obter
{
    public class ObterTarefaCommand : IRequest<Tarefa?>
    {
        public string Id { get; private set; }

        public ObterTarefaCommand(string id)
        {
            Id = id;
        }
    }
}
