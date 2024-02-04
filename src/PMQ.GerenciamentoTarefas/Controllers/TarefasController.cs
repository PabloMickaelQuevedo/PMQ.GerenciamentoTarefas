using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Adicionar;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Atualizar;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Remover;
using PMQ.GerenciamentoTarefas.Domain.Querys.Tarefas.Listar;
using PMQ.GerenciamentoTarefas.Domain.Querys.Tarefas.Obter;
using PMQ.GerenciamentoTarefas.Models.Tarefas.Adicionar;
using PMQ.GerenciamentoTarefas.Models.Tarefas.Listar;
using PMQ.GerenciamentoTarefas.Models.Tarefas.Obter;

namespace PMQ.GerenciamentoTarefas.Api.Controllers
{
    [Route("api/tarefas")]
    [ApiController]
    public class TarefasController : Controller
    {
        private readonly IMediator _mediator;

        public TarefasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<ListarTarefaResponse?>> ListarTarefasAsync([FromQuery] ListarTarefasQuery query, CancellationToken cancellationToken)
        {
            return ListarTarefaResponse.Map(await _mediator.Send(query, cancellationToken));
        }

        [HttpGet("{id}/obter")]
        public async Task<ObterTarefaResponse?> ObterTarefaPorIdAsync([FromRoute] string id, CancellationToken cancellationToken)
        {
            var query = new ObterTarefaQuery(id);
            return ObterTarefaResponse.Map(await _mediator.Send(query, cancellationToken));
        }

        [HttpPost("adicionar")]
        public async Task<AdicionarTarefaResponse> AdicionarTarefaAsync([FromBody] AdicionarTarefaCommand command, CancellationToken cancellationToken)
        {
            return new AdicionarTarefaResponse(await _mediator.Send(command, cancellationToken));
        }

        [HttpPut("{id}/atualizar")]
        public async Task<Unit> AtualizarTarefaAsync([FromRoute] string id, [FromBody] AtualizarTarefaCommand command, CancellationToken cancellationToken)
        {
            command.AtribuirId(id);
            return await _mediator.Send(command, cancellationToken);
        }

        [HttpDelete("{id}/remover")]
        public async Task<Unit> RemoverTarefaAsync([FromRoute] string id, CancellationToken cancellationToken)
        {
            var command = new RemoverTarefaCommand(id);
            return await _mediator.Send(command, cancellationToken);
        }
    }
}
