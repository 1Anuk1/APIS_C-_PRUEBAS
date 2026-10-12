using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace Prog1.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Operando : ControllerBase
{
    [HttpGet("Suma/{Numero1:int}/{Numero2:int}")]
    public IActionResult Suma(int Numero1, int Numero2)
    {
        return Ok(Numero1 + Numero2);
    }

    [HttpGet("Resta/{Numero1:int}/{Numero2:int}")]
    public IActionResult Resta(int Numero1, int Numero2)
    {
        return Ok(Numero1 - Numero2);
    }

    [HttpGet("Multipilicacion/{Numero1:int}/")]

    public IActionResult Multipicacion(int Numero1, int Numero2)
    {
        return Ok(Numero1 * Numero2);
    }

    [HttpGet("Promedio/{calif1:int}/{calif2:int}/{calif3:int}")]

    public IActionResult Promedio(int calif1, int calif2, int calif3)
    {
        return Ok((calif1 + calif2 + calif3) / 3);
    }

    [HttpGet("Raiz/{numraiz:int}")]

    public IActionResult Raiz(int numraiz)
    {
        return Ok($"La raiz de {numraiz} es {numraiz * numraiz}");
    }

    [HttpGet("Area del Cuadrado/{lado:int}")]

    public IActionResult AreaDelCuadrado(int lado)
    {
        return Ok($"El área del cuadrado con lado {lado} es {lado * lado}");
    }

    [HttpGet("Perimetro del Cuadrado/{lado:int}")]

    public IActionResult PerimetroDelCuadrado(int lado)
    {
        return Ok($"El perímetro del cuadrado con lado {lado} es {4 * lado}");
    }

    [HttpGet("Area del circulo/{radio:int}")]

    public IActionResult AreaDelCirculo(int radio)
    {
        return Ok($"El área del círculo con radio {radio} es {Math.PI * radio * radio}");
    }

    [HttpGet("Perimetro del circulo/{radio:int}")]

    public IActionResult PerimetroDelCirculo(int radio)
    {
        return Ok($"El perímetro del círculo con radio {radio} es {2 * Math.PI * radio}");
    }

    [HttpGet("Area del rectangulo/{baserect:int}/{alturarect:int}")]

    public IActionResult AreaDelRectangulo(int baserect, int alturarect)
    {
        return Ok($"El área del rectángulo con base {baserect} y altura {alturarect} es {baserect * alturarect}");
    }

    [HttpGet ("Area del triangulo/{basetri:int}/{alturatri:int}")]

    public IActionResult AreaDelTriangulo(int basetri, int alturatri)
    {
        return Ok($"El área del triángulo con base {basetri} y altura {alturatri} es {(basetri * alturatri) / 2}");
    }

    [HttpGet("Comparando 0 /{num:int}")]

    public IActionResult Comparando0(int num)
    {
        if (num == 0)
        {
            return Ok ($"El numero es igual a 0");
        }

        if (num < 0)
        {
            return Ok ($"El numero es menor a 0");
        }

        else
        {
            return Ok ($"El numero es mayor a 0");
        }

    }

[HttpGet("Promedio/{calif1:int}/{calif2:int}/{calif3:int}/{calif4:int}/{calif5:int}")]

public IActionResult promedio(int calif1, int calif2, int calif3, int calif4, int calif5)
    {
        int promedio = (calif1 + calif2 + calif3 + calif4 + calif5) / 5;

        if (promedio < 60)
        {
            return Ok($"La calificacion {promedio}, es reprobatorio");
        }

        else
        {
            return Ok($"La calificacion {promedio}, es aprobatoria");
        }

    }

    [HttpGet("Comparador de numeros+/{num1:int}/{num2:int}/{num3:int}")]

    public IActionResult Comparadormas(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            return Ok($"El numero {num1} es el mayor de los tres");
        }

        else if (num2 > num1 && num2 > num3)
        {
            return Ok($"El numero {num2} es el mayor de los tres");
        }

        else
        {
            return Ok($"El numero {num3} es el mayor de los tres");
        }
    }

     [HttpGet("Comparador de numeros-/{num1:int}/{num2:int}/{num3:int}")]

    public IActionResult Comparadormenos(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            return Ok($"El numero {num1} es el menor de los tres");
        }

        else if (num2 < num1 && num2 < num3)
        {
            return Ok($"El numero {num2} es el menor de los tres");
        }

        else
        {
            return Ok($"El numero {num3} es el menor de los tres");
        }
    }

    [HttpGet("Par o no par/{num1:double}")]

    public IActionResult Paronopar(double num1)
    {
       

        if (num1 % 2 == 0)
        {
            return Ok ($"El numero es par");
        }

        else
        {
            return Ok ($"El numero es inpar");
        }

    }

    [HttpGet("Vocales/{letra}")]

    public IActionResult vocales(string letra)
    {
        if(!(letra == "a"|| letra =="e" || letra =="i" ||letra =="o"||letra =="u"  ))
        {
            return Ok($"La letra no es una vocal");
        }
        else
        {
            return Ok($"La letra es una vocal");
        }

        }

    }















