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
}