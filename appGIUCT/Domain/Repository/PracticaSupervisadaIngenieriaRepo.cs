using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class PracticaSupervisadaIngenieriaRepo : IPracticaSupervisadaIngenieria
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public PracticaSupervisadaIngenieriaRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<PracticaSupervisadaIngenieria>> GetPracticaSupervisadaIngenieria()
             {
                 return await this.gIUCTDbContext.PracticaSupervisadaIngenieria.ToListAsync();
             }
            
             public async Task<PracticaSupervisadaIngenieria> GetPracticaSupervisadaIngenieriaId(int idP)
             {
                 return await gIUCTDbContext.PracticaSupervisadaIngenieria.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<PracticaSupervisadaIngenieria?> Add(PracticaSupervisadaIngenieria practicaSupervisadaIngenieria) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.PracticaSupervisadaIngenieria.AddAsync(practicaSupervisadaIngenieria); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<PracticaSupervisadaIngenieria> Modificar(PracticaSupervisadaIngenieria practicaSupervisadaIngenieria)
        {
            var result = await gIUCTDbContext.PracticaSupervisadaIngenieria
                .FirstOrDefaultAsync(e => e.Id == practicaSupervisadaIngenieria.Id);

            if (result != null)
            {
                result.docenteSupervisor = practicaSupervisadaIngenieria.docenteSupervisor;
                result.tutor = practicaSupervisadaIngenieria.tutor;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarPracticaSupervisadaIngenieria(int id)
        {
            var result = await gIUCTDbContext.PracticaSupervisadaIngenieria
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.PracticaSupervisadaIngenieria.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Practica Supervisada de Ingenieria con Id = {id}");
            
        }
        }
}