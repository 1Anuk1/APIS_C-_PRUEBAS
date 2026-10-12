using Dapper;
using Prog1.Api.Common;
using Prog1.Api.Features.Alumnos.Dominio.Dto;
using Prog1.Api.Features.Alumnos.Dominio.Entidad;

namespace Prog1.Api.Features.Alumnos;


public class AlumnoService(Data.DbContext db)
{
	private readonly Data.DbContext _db = db;

	public async Task<ApiResponse<IEnumerable<Alumno>>> ObtenerTodos()
	{
		using var connection = _db.CreateConnection();
		var sql = @"SELECT a.IdAlumno,
						   a.Nombre,
						   a.Apaterno,
						   a.AMaterno,
						   a.IdCarrera,
						   a.FecRegistro,
						   c.Descripcion AS Carrera
					FROM ALUMNO a
					INNER JOIN CARRERA c ON a.IdCarrera = c.IdCarrera
					ORDER BY a.APaterno, a.AMaterno, a.Nombre";

		var alumnos = await connection.QueryAsync<Alumno>(sql);
		return ApiResponse<IEnumerable<Alumno>>.Ok(alumnos);
	}
}

