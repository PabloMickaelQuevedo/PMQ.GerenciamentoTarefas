using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Remover
{
    public class RemoverTarefaCommandHandler : IRequestHandler<RemoverTarefaCommand, Unit>
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RemoverTarefaCommandHandler(ITarefaRepository tarefaRepository, IUnitOfWork unitOfWork)
        {
            _tarefaRepository = tarefaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(RemoverTarefaCommand request, CancellationToken cancellationToken)
        {
            var tarefa = await _tarefaRepository.ObterPorIdAsync(request.Id, cancellationToken);
            if (tarefa is null)
                throw new ArgumentException("Tarefa não encontrada.");

            try
            {
                _tarefaRepository.Remover(tarefa);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível remover a tarefa. Erro: {ex.Message}");
            }

            return default;
        }
    }
}
