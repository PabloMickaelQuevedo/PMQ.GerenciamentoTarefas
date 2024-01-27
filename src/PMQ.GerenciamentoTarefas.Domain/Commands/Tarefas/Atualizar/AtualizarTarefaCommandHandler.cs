using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Atualizar
{
    internal class AtualizarTarefaCommandHandler : IRequestHandler<AtualizarTarefaCommand, Unit>
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AtualizarTarefaCommandHandler(ITarefaRepository tarefaRepository, IUnitOfWork unitOfWork)
        {
            _tarefaRepository = tarefaRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(AtualizarTarefaCommand request, CancellationToken cancellationToken)
        {
            var tarefa = await _tarefaRepository.ObterPorIdAsync(request.Id, cancellationToken);
            if (tarefa is null)
                throw new ArgumentException("Tarefa não encontrada.");

            tarefa.Atualizar(
                request.Titulo,
                request.Descricao,
                request.DataVencimento,
                request.Prioridade,
                request.Etiquetas,
                request.Status);

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível atualizar a tarefa. Erro: {ex.Message}");
            }

            return default;
        }
    }
}
