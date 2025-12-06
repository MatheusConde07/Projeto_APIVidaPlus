namespace APIVidaPlus.Models;

public class Usuario
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string TipoUsuario { get; set; } = string.Empty; // Médico, Paciente, Administrador
}
