using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Querys.Tarefas.Obter
{
    public class ObterTarefaQueryHandler : IRequestHandler<ObterTarefaQuery, Tarefa?>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public ObterTarefaQueryHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<Tarefa?> Handle(ObterTarefaQuery request, CancellationToken cancellationToken)
        {
            return await _tarefaRepository.ObterPorIdAsync(request.Id, cancellationToken);
        }
    }
}
