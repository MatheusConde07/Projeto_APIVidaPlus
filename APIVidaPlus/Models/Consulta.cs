namespace APIVidaPlus.Models;

public class Consulta
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public int MedicoId {get; set;}
    public DateTime DataHora { get; set; }
    public string Status { get; set; } = "Agendada"; // Agendada, Concluída, Cancelada

}
