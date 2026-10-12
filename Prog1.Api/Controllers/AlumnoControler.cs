using Microsoft.AspNetCore.Mvc;
using Prog1.Api.Features.Alumnos;
using Prog1.Api.Features.Alumnos.Dominio.Dto;

namespace Prog1.Api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AlumnoControler(AlumnoService service) : ControllerBase
{
    private readonly AlumnoService _service = service;

    [HttpGet("ObtenerTodos")]
    public async Task<IActionResult> ObtenerTodos()
    {
        return Ok(await _service.ObtenerTodos());
    }
}
