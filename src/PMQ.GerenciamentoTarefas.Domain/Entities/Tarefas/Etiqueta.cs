namespace PMQ.GerenciamentoTarefas.Domain.Entities.Tarefas
{
    public class Etiqueta : Entity
    {
        public string Nome { get; private set; }

        public Etiqueta(string nome)
        {
            Nome = nome;
        }
    }
}
