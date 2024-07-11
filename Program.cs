
using Microsoft.EntityFrameworkCore;

namespace back
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			//*************************************************** INICIO Mis intervenciones
			//CONTEXTO BDD
			builder.Services.AddDbContext<AplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

			//CORS
			builder.Services.AddCors(options =>
			{
				options.AddPolicy("PermitirAppWeb", builder =>
				{
					builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
				});
			});
			//recuerda agregar app.UseCors("PermitirAppWeb");

			//*************************************************** FIN Mis intervenciones



			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			app.UseCors("PermitirAppWeb");
			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
