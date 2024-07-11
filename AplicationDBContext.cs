using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back
{
	public class AplicationDBContext: DbContext
	{
		public DbSet<TarjetaCredito> TarjetaCredito { get; set; } //Esta linea, mapea el modelo con la tabla de BDD. Nombre de la BDD que vamos a utilizar
		public AplicationDBContext(DbContextOptions<AplicationDBContext> options):base(options) { 
		
		}
		
	}
}
