using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Obter
{
    public class ObterTarefaCommandHandler : IRequestHandler<ObterTarefaCommand, Tarefa?>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public ObterTarefaCommandHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<Tarefa?> Handle(ObterTarefaCommand request, CancellationToken cancellationToken)
        {
            return await _tarefaRepository.ObterTarefaPorId(request.Id, cancellationToken);
        }
    }
}
