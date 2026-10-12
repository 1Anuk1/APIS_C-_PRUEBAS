using System.Text.RegularExpressions;

namespace Prog1.Api.Servicios;

public class BL_Clientes
{
    public static List<string> Validaciones(string nombre, string apaterno, string amaterno, string rfc, string calle, string colonia, int cp)
    {
        List<string> lstErrores = new List<string>();

        if (nombre.Replace(" ", "").Length < 3)
        {
            lstErrores.Add("El nombre es obligatorio y debe tener al menos 3 caracteres");
        }
        if (Validatexto(nombre))
        {
            lstErrores.Add("El nombre solo debe contener letras");
        }
        if (apaterno.Replace(" ", "").Length < 3)
        {
            lstErrores.Add("El apellido paterno es obligatorio y debe tener al menos 3 caracteres");
        }
        if (Validatexto(apaterno))
        {
            lstErrores.Add("El apellido paterno solo debe contener letras");
        }

        if (amaterno.Replace(" ", "").Length < 3)
        {
            lstErrores.Add("El apellido materno es obligatorio y debe tener al menos 3 caracteres");
        }
        if (Validatexto(amaterno))
        {
            lstErrores.Add("El apellido materno solo debe contener letras");
        }

        // Validar RFC
        if (!ValidaRFC(rfc))
        {
            lstErrores.Add("El RFC no cumple con el formato correcto.");
        }

        // Validar calle
        if (calle.Length < 4 || calle.Length > 100)
        {
            lstErrores.Add("La calle debe tener entre 5 y 100 caracteres.");
        }

        // Validar colonia
        if (colonia.Length < 4 || colonia.Length > 100)
        {
            lstErrores.Add("La colonia debe tener entre 5 y 100 caracteres.");
        }

        // Validar código postal
        if (cp < 10000 || cp > 99999)
        {
            lstErrores.Add("El código postal debe ser un número de 5 dígitos.");
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

    private static bool ValidaRFC(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
        {
            return false;
        }

        texto = texto.Trim().ToUpperInvariant();

        return Regex.IsMatch(
            texto,
            @"^[A-ZÑ&]{4}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])[A-Z0-9]{3}$");



    }



}
