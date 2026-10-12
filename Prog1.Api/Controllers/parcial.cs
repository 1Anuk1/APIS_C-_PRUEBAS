using Microsoft.AspNetCore.Mvc;

namespace Prog1.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Parcial : ControllerBase
{
  [HttpGet("Suma/{num1:int}/{num2:int}")]  

  public IActionResult sumando(int num1, int num2)
    {
        int suma = num1 + num2;

        return Ok(suma);





    }


   [HttpGet("tablas/{num:int}")] 

   public IActionResult Tabla(int num)
    {
        List<string> operacion = new List<string>();
        for(int i = 1; i <= 67; i++)
        {
         int Multipicacion = i * num;
         string Linea = $"{num} x {i} = {Multipicacion}";

         operacion.Add(Linea);  
        }
        return Ok(operacion);
    }

}
