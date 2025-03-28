using System.ComponentModel.DataAnnotations;

namespace Backend.Domain.Entities
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? ConcluidoEm { get; set; }
        public TarefaStatus Status { get; set; } = TarefaStatus.Pendente;
    }
}
