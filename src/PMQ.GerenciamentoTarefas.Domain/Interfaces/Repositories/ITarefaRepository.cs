using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> ListarAsync(CancellationToken cancellationToken);
        Task<Tarefa?> ObterTarefaPorId(string id, CancellationToken cancellationToken);
    }
}
