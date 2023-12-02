using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Serilog.Events;

namespace appGIUCT.Domain.Repository
{
    public class EnsayoCatedraRepo : IEnsayoCatedraRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext;
            public readonly ILogger _logger;
            
            public EnsayoCatedraRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext = gIUCTDbContext;
                _logger = logger;
            }
            public async Task<IEnumerable<EnsayoCatedra>> GetEnsayoCatedra()
             {
                 return await this.gIUCTDbContext.EnsayoCatedra.ToListAsync();
             }
            
             public async Task<EnsayoCatedra> GetEnsayoCatedraId(int idP)
             {
                 return await gIUCTDbContext.EnsayoCatedra.FirstOrDefaultAsync(f => f.Id == idP);
             }


             public async Task<EnsayoCatedra?> Add(EnsayoCatedra ensayoCatedra) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
             {
                 var result = await gIUCTDbContext.EnsayoCatedra.AddAsync(ensayoCatedra); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

                 return result.Entity;
             }

         public async Task<EnsayoCatedra> Modificar(EnsayoCatedra ensayoCatedra)
        {
            var result = await gIUCTDbContext.EnsayoCatedra
                .FirstOrDefaultAsync(e => e.Id == ensayoCatedra.Id);

            if (result != null)
            {
                result.docente = ensayoCatedra.docente;
                result.tutor = ensayoCatedra.tutor;
             
                await gIUCTDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }     

    public async Task<IActionResult> EliminarEnsayoCatedra(int id)
        {
            var result = await gIUCTDbContext.EnsayoCatedra
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                gIUCTDbContext.EnsayoCatedra.Remove(result);
                await gIUCTDbContext.SaveChangesAsync();
                return new OkObjectResult("Eliminado con éxito");

            }

            return new NotFoundObjectResult($"No se encontró Ensayo de Catedra con Id = {id}");
            
        }
        }
}