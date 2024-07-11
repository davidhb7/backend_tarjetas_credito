using System.ComponentModel.DataAnnotations;

namespace back.Models
{
	public class TarjetaCredito
	{
		[Key]
		public int Id { get; set; }

		public required string Titular { get; set; }

		public required string NumeroTarjeta { get; set; }

		public required string FechaVencimiento { get; set; }

		public required string Cvv { get; set;}
	}
}
