using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Obter;
using PMQ.GerenciamentoTarefas.Models.Tarefas.Listar;
using PMQ.GerenciamentoTarefas.Models.Tarefas.Obter;

namespace PMQ.GerenciamentoTarefas.Controllers
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
        public async Task<IEnumerable<ListarTarefaResponse?>> ListarTarefasAsync([FromQuery] ListarTarefasCommand command, CancellationToken cancellationToken)
        {
            return ListarTarefaResponse.Map(await _mediator.Send(command, cancellationToken));
        }

        [HttpGet("{id}")]
        public async Task<ObterTarefaResponse?> ObterTarefaPorIdAsync([FromRoute] string id, CancellationToken cancellationToken)
        {
            var command = new ObterTarefaCommand(id);
            return ObterTarefaResponse.Map(await _mediator.Send(command, cancellationToken));
        }
    }
}
