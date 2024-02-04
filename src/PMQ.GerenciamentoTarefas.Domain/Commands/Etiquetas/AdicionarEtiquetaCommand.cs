using MediatR;

namespace PMQ.GerenciamentoTarefas.Domain.Commands.Etiquetas
{
    public class AdicionarEtiquetaCommand : IRequest<string>
    {
        public string Nome { get; set; }
    }
}
