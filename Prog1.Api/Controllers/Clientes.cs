using Microsoft.AspNetCore.Mvc;
using Prog1.Api.Servicios;

namespace Prog1.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Clientes : ControllerBase
{
    [HttpGet("RegistroCCliente")]

    public IActionResult RegistroCliente()
    {
        string nombre = "julian";
        string apaterno = "alvarez";
        string amaterno = "Lopez";
        string rfc = "ALMV040521V90";
        string calle = "Calle 1";
        string colonia = "Colonia 1";
        int cp = 12345;

    List<string> lstErrores = BL_Clientes.Validaciones(nombre, apaterno, amaterno, rfc, calle, colonia, cp);

    if (lstErrores.Count == 0)
        {
            return Ok(new
            {
                code = "00",
                value = "",
                Msg = ""
            });
        }
        else
        {
            return Ok(new
            {
                code = "01",
                value = lstErrores,
                Msg = ""
            });
        } 
        
    }

}

     