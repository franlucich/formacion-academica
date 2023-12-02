using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface ITesisPosgradoRepo
    {
        Task<IEnumerable<TesisPosgrado>> GetTesisPosgrado();
        Task<TesisPosgrado?> GetTesisPosgradoId( int idP);
        Task<TesisPosgrado> Add(TesisPosgrado tesisPosgrado);
        Task<TesisPosgrado> Modificar(TesisPosgrado tesisPosgrado);
        Task<IActionResult> EliminarTesisPosgrado(int id);
    }
}