using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class TesinaLicenciaturaRepo : ITesinaLicenciaturaRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public TesinaLicenciaturaRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<TesinaLicenciatura>> GetTesinaLicenciatura()
             {
                 return await this.gIUCTDbContext.TesinaLicenciatura.ToListAsync();
             }
            
             public async Task<TesinaLicenciatura> GetTesinaLicenciaturaId(int idP)
             {
                 return await gIUCTDbContext.TesinaLicenciatura.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<TesinaLicenciatura?> Add(TesinaLicenciatura tesinaLicenciatura) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.TesinaLicenciatura.AddAsync(tesinaLicenciatura); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<TesinaLicenciatura> Modificar(TesinaLicenciatura tesinaLicenciatura)
        {
            var result = await gIUCTDbContext.TesinaLicenciatura
                .FirstOrDefaultAsync(e => e.Id == tesinaLicenciatura.Id);

            if (result != null)
            {
                result.director = tesinaLicenciatura.director;
                result.fuenteFinanciamiento = tesinaLicenciatura.fuenteFinanciamiento;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarTesinaLicenciatura(int id)
        {
            var result = await gIUCTDbContext.TesinaLicenciatura
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.TesinaLicenciatura.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Tesina de Licenciatura con Id = {id}");
            
        }
        }
}