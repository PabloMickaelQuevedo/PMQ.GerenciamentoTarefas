using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;

namespace PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> ListarAsync(CancellationToken cancellationToken);
        Task<Tarefa?> ObterPorIdAsync(string id, CancellationToken cancellationToken);
        Task AdicionarAsync(Tarefa tarefa, CancellationToken cancellationToken);
        void Remover (Tarefa tarefa);
    }
}
