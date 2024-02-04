using MediatR;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Etiquetas
{
    public class AdicionarEtiquetaCommandHandler : IRequestHandler<AdicionarEtiquetaCommand, string>
    {
        private readonly IEtiquetaRepository _etiquetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AdicionarEtiquetaCommandHandler(IEtiquetaRepository etiquetaRepository, IUnitOfWork unitOfWork)
        {
            _etiquetaRepository = etiquetaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(AdicionarEtiquetaCommand request, CancellationToken cancellationToken)
        {
            var etiqueta = new Etiqueta(request.Nome) 
                ?? throw new ArgumentException("Não foi possível criar uma Etiqueta");

            try
            {
                await _etiquetaRepository.AdicionarAsync(etiqueta, cancellationToken);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível adicionar a etiqueta. Erro: {ex.Message}");
            }

            return etiqueta.Id;
        }
    }
}
