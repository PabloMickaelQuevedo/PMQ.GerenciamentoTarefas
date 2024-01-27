using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar
{
    public class ListarTarefasQueryHandler : IRequestHandler<ListarTarefasQuery, IEnumerable<Tarefa>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public ListarTarefasQueryHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<IEnumerable<Tarefa>> Handle(ListarTarefasQuery request, CancellationToken cancellationToken)
        {
            return await _tarefaRepository.ListarAsync(cancellationToken);
        }
    }
}
