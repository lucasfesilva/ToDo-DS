using Backend.Domain.Entities;

namespace Backend.Domain.Interfaces
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> GetAllAsync();
        Task<Tarefa> GetByIdAsync(int id);
        Task AddAsync(Tarefa tarefa);
        Task DeleteAsync(Tarefa tarefa);
        Task UpdateAsync(Tarefa tarefa);
    }
}

