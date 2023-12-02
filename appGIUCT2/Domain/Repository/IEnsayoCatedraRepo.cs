using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IEnsayoCatedraRepo
    {
        Task<IEnumerable<EnsayoCatedra>> GetEnsayoCatedra();
        Task<EnsayoCatedra?> GetEnsayoCatedraId( int idP);
        Task<EnsayoCatedra> Add(EnsayoCatedra ensayoCatedra);
        Task<EnsayoCatedra> Modificar(EnsayoCatedra ensayoCatedra);
        Task<IActionResult> EliminarEnsayoCatedra(int id);
    }
}