using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class FormRepo : IFormRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public FormRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<FormacionAcademica>> GetFormA()
             {
                 return await this.gIUCTDbContext.FormacionAcademicas.ToListAsync();
             }
            
             public async Task<FormacionAcademica> GetFormacionAcademicaId(int idP)
             {
                 return await gIUCTDbContext.FormacionAcademicas.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<FormacionAcademica?> Add(FormacionAcademica formacionAcademica) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.FormacionAcademicas.AddAsync(formacionAcademica); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<FormacionAcademica> Modificar(FormacionAcademica formacionAcademica)
        {
            var result = await gIUCTDbContext.FormacionAcademicas
                .FirstOrDefaultAsync(e => e.Id == formacionAcademica.Id);

            if (result != null)
            {
                result.titulo = formacionAcademica.titulo;
                result.fechaFin = formacionAcademica.fechaFin;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarForm(int id)
        {
            var result = await gIUCTDbContext.FormacionAcademicas
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.FormacionAcademicas.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró formacion academica con Id = {id}");
            
        }
        }
}