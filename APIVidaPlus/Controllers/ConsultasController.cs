using APIVidaPlus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[Route("api/consultas")]
[ApiController]
[Authorize] // Exige o Token que foi gerado no login
public class ConsultasController : ControllerBase
{
    private static List<Consulta> _consultas = new List<Consulta>(); // Banco de dados em memória

    [HttpPost]
    public IActionResult Agendar([FromBody] Consulta novaConsulta)
    {
        novaConsulta.Id = _consultas.Count + 1;
        _consultas.Add(novaConsulta);
        return Created("", novaConsulta);
    }

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(_consultas);
    }

    // PUT: api/consultas/{id}
    // Serve para atualizar (exemplo: mudar data)
    [HttpPut("{id}")]
    public IActionResult AtualizarConsulta(int id, [FromBody] Consulta consultaEditada)
    {
        // Busca na memória
        var consultaAlvo = _consultas.FirstOrDefault(c => c.Id == id);

        if (consultaAlvo == null)
            return NotFound(new { mensagem = "Consulta não encontrada." });

        // Atualiza os dados
        consultaAlvo.Status = consultaEditada.Status;
        consultaAlvo.DataHora = consultaEditada.DataHora;
        consultaAlvo.MedicoId = consultaEditada.MedicoId;

        // Retorna 204 (No Content) que é padrão para Updates com sucesso
        return NoContent();
    }
}