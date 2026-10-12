namespace Prog1.Api.Features.Alumnos.Dominio.Entidad;

public class Alumno
{
	public int IdAlumno { get; set; }
	public string Nombre { get; set; } = string.Empty;
	public string Apaterno { get; set; } = string.Empty;
	public string Amaterno { get; set; } = string.Empty;
	public int IdCarrera { get; set; }
	public DateTime FecRegistro { get; set; }
	public string Carrera { get; set; } = string.Empty;
}
