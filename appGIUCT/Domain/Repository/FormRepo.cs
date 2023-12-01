using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repositores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repositores
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
            public async Task<IEnumerable<EnsayoCatedra>> GetFormA()
             {
                 return await this.gIUCTDbContext.EnsayoCatedra.ToListAsync();
             }
            
            public async Task<EnsayoCatedra> GetFormId(int idP)
             {
                 return await gIUCTDbContext.EnsayoCatedra.FirstOrDefaultAsync(f => f.Id == idP);
             }


         public async Task<EnsayoCatedra?> Add(EnsayoCatedra ensayo) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.EnsayoCatedra.AddAsync(ensayo); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<EnsayoCatedra> Modificar(EnsayoCatedra ensayo)
        {
            var result = await gIUCTDbContext.EnsayoCatedra
                .FirstOrDefaultAsync(e => e.Id == ensayo.Id);

            if (result != null)
            {
                result.titulo = ensayo.titulo;
                result.fechaFin = ensayo.fechaFin;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
         public async Task<EnsayoCatedra> ModEnsayo(EnsayoCatedra ensayo)
        {
            var result = await gIUCTDbContext.EnsayoCatedra
                .FirstOrDefaultAsync(e => e.Id == ensayo.Id);

            if (result != null)
            {
                result.titulo = ensayo.titulo;
                result.fechaFin = ensayo.fechaFin;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }          

         public async Task<IActionResult> EliminarForm(int id)
        {
            var result = await gIUCTDbContext.EnsayoCatedra
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.EnsayoCatedra.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró formacion academica con Id = {id}");
            
        }
        }

       }
