using MediatR;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar
{
    public class ListarTarefasCommandHandler : IRequestHandler<ListarTarefasCommand, IEnumerable<string>>
    {
        public async Task<IEnumerable<string>> Handle(ListarTarefasCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new List<string> { "value1", "value2" });
        }
    }
}
