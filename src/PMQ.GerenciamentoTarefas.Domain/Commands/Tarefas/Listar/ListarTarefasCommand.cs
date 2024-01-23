using MediatR;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar
{
    public class ListarTarefasCommand : IRequest<IEnumerable<string>>
    {
    }
}
