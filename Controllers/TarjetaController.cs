using back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TarjetaController : ControllerBase
	{
		private readonly AplicationDBContext _dbContext;
		public TarjetaController(AplicationDBContext aplicationDBContext) 
		{
			_dbContext = aplicationDBContext;
		}



		// GET: api/<TarjetaController>
		//TRAE TODAS LAS TARJETAS
		[HttpGet]
		public async Task<IActionResult> GetGeneral()
		{
			try
			{
				var listartarjetas = await _dbContext.TarjetaCredito.ToListAsync();//Lo obtenido, lo convierte en una lista asincrona, espera el resultado
				return Ok(listartarjetas);	
			}
			catch (Exception ex)
			{
				return BadRequest("BR Get General ex: "+ex.Message);
			}
		}

		// GET api/<TarjetaController>/5
		// TARJETA ESPECIFICA POR ID*****************************CREAR
		//[HttpGet("{id}")]
		//public string Get(int id)
		//{
		//	return "value";
		//}

		// POST api/<TarjetaController>
		//ACTUALIZAR INFORMACION
		[HttpPost]
		public async Task<IActionResult> PostTarjeta([FromBody] TarjetaCredito tarjetaCredito)
		{
			try
			{
				//LE PASA EL OBJETO AL CONTEXTO
				_dbContext.Add(tarjetaCredito);
				//ESPERA A QUE TERMINE DE GUARDAR
				await _dbContext.SaveChangesAsync();
				//RETORNA EL OBJETO GUARDADO
				return Ok(tarjetaCredito);
			}
			catch(Exception ex) {
				return BadRequest("BR Post ex: " + ex.Message);	 
			}
		}

		// PUT api/<TarjetaController>/5
		//CREAR INFORMACION
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTarjeta(int id, [FromBody] TarjetaCredito tarjetaCredito)
		{
			try
			{
				if(tarjetaCredito.Id != id)
				{
					return NotFound();
				}
				_dbContext.Update(tarjetaCredito);
				await _dbContext.SaveChangesAsync();
				return Ok(new {message= "Tarjeta actualizada correctamente"});
			}
			catch (Exception ex)
			{
				return BadRequest("BR Put ex: " + ex.Message);
			}
		}

		// DELETE api/<TarjetaController>/5
		//ELIMINAR INFORMACION
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTarjeta(int id)
		{
			try
			{
				var tarjetaID = await _dbContext.TarjetaCredito.FindAsync(id);//Busca la tarjeta con el id del parametro

				if(tarjetaID == null)
				{
					return NotFound();
				}
				_dbContext.TarjetaCredito.Remove(tarjetaID);
				await _dbContext.SaveChangesAsync();
				return Ok(new { message = "Tarjeta eliminada correctamente" });

			}
			catch (Exception ex)
			{
				return BadRequest("BR Delete ex: " + ex.Message);
			}
		}
	}
}
