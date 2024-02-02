using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Querys.Tarefas.Listar
{
    public class ListarTarefasQuery : IRequest<IEnumerable<Tarefa>>
    {
    }
}
