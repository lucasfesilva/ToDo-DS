using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        IEnumerable<Tarefa> GetAll();
    }
}
