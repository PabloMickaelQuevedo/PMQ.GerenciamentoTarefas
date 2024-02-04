using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMQ.GerenciamentoTarefas.Domain.Commands.Etiquetas;

namespace PMQ.GerenciamentoTarefas.Api.Controllers
{
    [Route("api/etiquetas")]
    [ApiController]
    public class EtiquetasController : Controller
    {
        private readonly IMediator _mediator;

        public EtiquetasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<string> AdicionarEtiquetaAsync([FromBody] AdicionarEtiquetaCommand command, CancellationToken cancellationToken)
        {
            return await _mediator.Send(command, cancellationToken);
        }
    }
}
