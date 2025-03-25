using Backend.Domain.Entities;

namespace Backend.Application.Interfaces
{
    public interface ITarefaService
    {
        IEnumerable<Tarefa> GetAll();
    }
}
