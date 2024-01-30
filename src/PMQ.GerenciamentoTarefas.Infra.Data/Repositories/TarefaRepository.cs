using Microsoft.EntityFrameworkCore;
using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;
using PMQ.GerenciamentoTarefas.Infra.Data.Context;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly TarefaContext _tarefacontext;

        public TarefaRepository(TarefaContext tarefacontext)
        {
            _tarefacontext = tarefacontext;
        }

        public async Task<IEnumerable<Tarefa>> ListarAsync(CancellationToken cancellationToken)
        {
            return await _tarefacontext.Tarefas
                .Include(t => t.Etiquetas)
                .OrderBy(t => t.DataVencimento)
                .ThenBy(t => t.Prioridade)
                .ToListAsync(cancellationToken);
        }

        public async Task<Tarefa?> ObterPorIdAsync(string id, CancellationToken cancellationToken)
        {
            return await _tarefacontext.Tarefas
                .Include(t => t.Etiquetas)
                .FirstOrDefaultAsync(t => t.Id == id, cancellationToken);
        }

        public async Task AdicionarAsync(Tarefa tarefa, CancellationToken cancellationToken)
        {
            await _tarefacontext.AddAsync(tarefa, cancellationToken);
        }

        public void Remover(Tarefa tarefa)
        {
            _tarefacontext.Remove(tarefa);
        }
    }
}
