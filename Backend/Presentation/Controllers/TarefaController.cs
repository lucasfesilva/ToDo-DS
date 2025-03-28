using Backend.Application.Interfaces;
using Backend.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;

        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _tarefaService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            return tarefa == null ? NotFound() : Ok(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(Tarefa tarefa)
        {
            if (tarefa.ConcluidoEm < tarefa.CriadoEm)
            {
                return BadRequest("A data de conclusão não pode ser menor que a data de criação!");
            }
            await _tarefaService.AddAsync(tarefa);
            return Ok(tarefa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            if (tarefa == null)
                return NotFound();
            await _tarefaService.DeleteAsync(tarefa);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            if (tarefa == null)
                return NotFound();
            await _tarefaService.UpdateAsync(tarefa);
            return Ok();
        }

    }
}
