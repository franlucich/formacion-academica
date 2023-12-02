using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class PracticaProfesionalizanteRepo : IPracticaProfesionalizanteRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public PracticaProfesionalizanteRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<PracticaProfesionalizante>> GetPracticaProfesionalizante()
             {
                 return await this.gIUCTDbContext.PracticaProfesionalizante.ToListAsync();
             }
            
             public async Task<PracticaProfesionalizante> GetPracticaProfesionalizanteId(int idP)
             {
                 return await gIUCTDbContext.PracticaProfesionalizante.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<PracticaProfesionalizante?> Add(PracticaProfesionalizante practicaProfesionalizante) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.PracticaProfesionalizante.AddAsync(practicaProfesionalizante); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<PracticaProfesionalizante> Modificar(PracticaProfesionalizante practicaProfesionalizante)
        {
            var result = await gIUCTDbContext.PracticaProfesionalizante
                .FirstOrDefaultAsync(e => e.Id == practicaProfesionalizante.Id);

            if (result != null)
            {
                result.docente = practicaProfesionalizante.docente;
                result.tutor = practicaProfesionalizante.tutor;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarPracticaProfesionalizante(int id)
        {
            var result = await gIUCTDbContext.PracticaProfesionalizante
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.PracticaProfesionalizante.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Practica Profesionalizante con Id = {id}");
            
        }
        }
}