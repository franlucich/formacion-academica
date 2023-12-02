using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class TesisPosgradoRepo : ITesisPosgradoRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public TesisPosgradoRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<TesisPosgrado>> GetTesisPosgrado()
             {
                 return await this.gIUCTDbContext.TesisPosgrado.ToListAsync();
             }
            
             public async Task<TesisPosgrado> GetTesisPosgradoId(int idP)
             {
                 return await gIUCTDbContext.TesisPosgrado.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<TesisPosgrado?> Add(TesisPosgrado tesisPosgrado) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.TesisPosgrado.AddAsync(tesisPosgrado); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<TesisPosgrado> Modificar(TesisPosgrado tesisPosgrado)
        {
            var result = await gIUCTDbContext.TesisPosgrado
                .FirstOrDefaultAsync(e => e.Id == tesisPosgrado.Id);

            if (result != null)
            {
                result.director = tesisPosgrado.director;
                result.fuenteFinanciamiento = tesisPosgrado.fuenteFinanciamiento;
                result.tipo = tesisPosgrado.tipo;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarTesisPosgrado(int id)
        {
            var result = await gIUCTDbContext.TesisPosgrado
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.TesisPosgrado.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Tesis de Posgrado con Id = {id}");
            
        }
        }
}