using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Adicionar
{
    internal class AdicionarTarefaCommandHandler : IRequestHandler<AdicionarTarefaCommand, string>
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AdicionarTarefaCommandHandler(IUnitOfWork unitOfWork, ITarefaRepository tarefaRepository)
        {
            _unitOfWork = unitOfWork;
            _tarefaRepository = tarefaRepository;
        }

        public async Task<string> Handle(AdicionarTarefaCommand request, CancellationToken cancellationToken)
        {
            var tarefa = new Tarefa(
                request.Titulo,
                request.Descricao,
                request.DataVencimento,
                request.Prioridade,
                request.Etiquetas,
                request.Status) 
                ?? throw new ArgumentException("Não foi possível criar a tarefa.");

            try
            {
                await _tarefaRepository.AdicionarAsync(tarefa, cancellationToken);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível adicionar a tarefa. Erro: {ex.Message}");
            }

            return tarefa.Id;
        }
    }
}
