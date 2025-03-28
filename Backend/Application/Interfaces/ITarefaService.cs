using Backend.Domain.Entities;

namespace Backend.Application.Interfaces
{
    public interface ITarefaService
    {
        Task<IEnumerable<Tarefa>> GetAllAsync();
        Task<Tarefa> GetByIdAsync(int id);
        Task AddAsync(Tarefa tarefa);
        Task DeleteAsync(Tarefa tarefa);
        Task UpdateAsync(Tarefa tarefa);
    }
}
