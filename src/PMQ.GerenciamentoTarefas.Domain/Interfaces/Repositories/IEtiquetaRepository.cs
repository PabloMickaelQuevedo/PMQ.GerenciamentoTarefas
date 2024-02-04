using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories
{
    public interface IEtiquetaRepository
    {
        Task AdicionarAsync(Etiqueta etiqueta, CancellationToken cancellationToken);
    }
}
