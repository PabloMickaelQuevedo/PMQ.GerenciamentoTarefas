using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMQ.GerenciamentoTarefas.Domain.Commands.Tarefas.Listar;

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
        public async Task<IEnumerable<string>> ListarTarefasAsync()
        {
            return await _mediator.Send(new ListarTarefasCommand());
        }
    }
}
