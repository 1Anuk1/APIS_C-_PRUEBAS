using System.Timers;
using Prog1.Api.Models;


namespace Prog1.Api.Servicios;

public class BL_Alumnos
{
    public static List<string> Validaciones(string nombre, string apaterno, string amaterno){
    
        List<string> lstErrores = new List<string>();






        if (string.IsNullOrEmpty(nombre))
        {
            lstErrores.Add("El nombre es obligatorio");
        }
        else if (Validatexto(nombre))
        {
            lstErrores.Add("El nombre no puede contener números");
        }

        if (string.IsNullOrEmpty(apaterno))
        {
            lstErrores.Add("El apellido paterno es obligatorio");
        }
        else if (Validatexto(apaterno))
        {
            lstErrores.Add("El apellido paterno no puede contener números");
        }

        if (string.IsNullOrEmpty(amaterno))
        {
            lstErrores.Add("El apellido materno es obligatorio");
        }
        else if (Validatexto(amaterno))
        {
            lstErrores.Add("El apellido materno no puede contener números");
        }

        return lstErrores;
    }




    private static bool Validatexto(string texto)
    {
        bool isActivo = false;

        foreach (char letra in texto.Replace(" ", ""))
        {
            if (!char.IsLetter(letra))
            {
                isActivo = true;
                break;
            }
        }

        return isActivo;
    }

}