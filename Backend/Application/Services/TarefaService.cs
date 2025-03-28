using Backend.Application.Interfaces;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces;

namespace Backend.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repository;

        public TarefaService(ITarefaRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Tarefa tarefa)
        {
            await _repository.AddAsync(tarefa);
        }

        public async Task DeleteAsync(Tarefa tarefa)
        {
            await _repository.DeleteAsync(tarefa);
        }

        public async Task<IEnumerable<Tarefa>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Tarefa> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Tarefa tarefa)
        {
            await _repository.UpdateAsync(tarefa);
        }
    }
}
