namespace PMQ.GerenciamentoTarefas.Models.Tarefas.Adicionar
{
    public class AdicionarTarefaResponse
    {
        public string Id { get; private set; }
 
        public AdicionarTarefaResponse(string id)
        {
            Id = id;
        }
    }
}
