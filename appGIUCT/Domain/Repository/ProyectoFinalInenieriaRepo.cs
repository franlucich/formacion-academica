using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class PoyectoFinalIngenieriaRepo : IProyectoFinalIngenieria
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public PoyectoFinalIngenieriaRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<ProyectoFinalIngenieria>> GetProyectoFinalIngenieria()
             {
                 return await this.gIUCTDbContext.ProyectoFinalIngenieria.ToListAsync();
             }
            
             public async Task<ProyectoFinalIngenieria> GetProyectoFinalIngenieriaId(int idP)
             {
                 return await gIUCTDbContext.ProyectoFinalIngenieria.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<ProyectoFinalIngenieria?> Add(ProyectoFinalIngenieria proyectoFinalIngenieria) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.ProyectoFinalIngenieria.AddAsync(proyectoFinalIngenieria); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                await gIUCTDbContext.SaveChangesAsync();
                 return result.Entity;
             }

         public async Task<ProyectoFinalIngenieria> Modificar(ProyectoFinalIngenieria proyectoFinalIngenieria)
        {
            var result = await gIUCTDbContext.ProyectoFinalIngenieria
                .FirstOrDefaultAsync(e => e.Id == proyectoFinalIngenieria.Id);

            if (result != null)
            {
                result.director = proyectoFinalIngenieria.director;
                result.fuenteFinanciemiento = proyectoFinalIngenieria.fuenteFinanciemiento;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarProyectoFinalIngenieria(int id)
        {
            var result = await gIUCTDbContext.ProyectoFinalIngenieria
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.ProyectoFinalIngenieria.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Proyecto Final de Ingenieria con Id = {id}");
            
        }
        }
}