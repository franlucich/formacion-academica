using appGIUCT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using appGIUCT.Domain.Repositores;

namespace appGIUCT.Domain.Repositores
{
    public class FormRepo : IFormRepo
        {
            private readonly GIUCTDbContext gIUCTDbContext1;
            public readonly ILogger _logger;
            
            public FormRepo(GIUCTDbContext gIUCTDbContext, ILogger logger)
            {
                this.gIUCTDbContext1 =gIUCTDbContext;
                _logger = logger;
            }
            // public async Task<IEnumerable<FormacionAcademica>> GetFormA()
            // {
            //     return await this.gIUCTDbContext1.a.ToListAsync();
            // }
            
        //     public async Task<List<Oferta?>> GetOfertaActiva(int idP)
        //     {
        //         return await this.ecommerceDbContext.Ofertas
        //         .Where(e => e.pkProveedor == idP && e.EstadoOferta == true)
        //         .ToListAsync();
        //     }


        //     public async Task<Oferta?> GetOferta(int ofertaId)
        //     {
        //         return await this.ecommerceDbContext.Ofertas.FirstOrDefaultAsync(e => e.Id == ofertaId);
        //     }

        //     public async Task<Oferta?> Add(Oferta oferta) // Método asincrónico para agregar una nueva oferta a través del contexto de la base de datos
        //     {
        //         var result = await ecommerceDbContext.Ofertas.AddAsync(oferta); // Utiliza el método AddAsync del contexto de la base de datos para agregar la oferta de manera asincrónica

        //         return result.Entity;
        //     }
        //     public async Task<Oferta?> Update(Oferta oferta)
        //     {
        //         var result = await ecommerceDbContext.Ofertas.FirstOrDefaultAsync(e => e.Id == oferta.Id);

        //         if(result != null)
        //         {
        //             result.NombreProducto = oferta.NombreProducto;
        //             result.Descripcion = oferta.Descripcion;
        //             result.Precio = oferta.Precio;
        //             result.EstadoOferta = oferta.EstadoOferta;
        //             result.stock = oferta.stock;
        //             result.Proveedor = oferta.Proveedor; 

        //             await ecommerceDbContext.SaveChangesAsync();

        //             return result;
                    
        //         }
        //         return null;
        //     }

        //     public async Task<Oferta?> Upsert(Oferta entity)
        //     {
        //         try
        //         {
        //             var existingOferta = await ecommerceDbContext.Ofertas.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

        //             if (existingOferta == null)
        //                 return await Add(entity);
                    
        //             existingOferta.NombreProducto = entity.NombreProducto;
        //             existingOferta.Descripcion = entity.Descripcion;
        //             existingOferta.Precio = entity.Precio;
        //             existingOferta.EstadoOferta = entity.EstadoOferta;
        //             existingOferta.stock = entity.stock;
        //             existingOferta.Proveedor = entity.Proveedor;

        //             return existingOferta;
        //         }
        //         catch (Exception ex)
        //         {
        //             _logger.LogError(ex, "{Repo} Upsert function error", typeof(OfertaRepository));
        //             return null;
        //         }
        //     }

            

        //     public async void Delete(int ofertaId)
        //     {
        //         var result = await ecommerceDbContext.Ofertas.FirstOrDefaultAsync(e => e.Id == ofertaId);
        //         if (result != null)
        //         {
        //             ecommerceDbContext.Ofertas.Remove(result);
        //             await ecommerceDbContext.SaveChangesAsync();
        //         }
        //     }

            
            
        }

}