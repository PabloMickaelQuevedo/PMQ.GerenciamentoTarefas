using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar
{
    public class ListarTarefasQuery : IRequest<IEnumerable<Tarefa>>
    {
    }
}
