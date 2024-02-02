namespace PMQ.GerenciamentoTarefas.Domain.Entities
{
    public abstract class Entity
    {
        public string Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
