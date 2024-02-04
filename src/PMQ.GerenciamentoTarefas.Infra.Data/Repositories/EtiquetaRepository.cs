using PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas;
using PMQ.GerenciamentoTarefas.Domain.Interfaces.Repositories;
using PMQ.GerenciamentoTarefas.Infra.Data.Context;

namespace PMQ.GerenciamentoTarefas.Infra.Data.Repositories
{
    public class EtiquetaRepository : IEtiquetaRepository
    {
        private readonly TarefaContext _context;

        public EtiquetaRepository(TarefaContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Etiqueta etiqueta, CancellationToken cancellationToken)
        {
            await _context.Etiquetas.AddAsync(etiqueta, cancellationToken);
        }
    }
}
