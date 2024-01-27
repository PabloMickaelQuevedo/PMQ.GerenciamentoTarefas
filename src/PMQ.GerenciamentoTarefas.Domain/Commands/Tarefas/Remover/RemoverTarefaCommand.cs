using MediatR;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Remover
{
    public class RemoverTarefaCommand : IRequest<Unit>
    {
        public string Id { get; private set; }

        public RemoverTarefaCommand(string id)
        {
            Id = id;
        }
    }
}
