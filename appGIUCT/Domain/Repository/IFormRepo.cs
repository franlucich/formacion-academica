using appGIUCT.Domain.Entities;

using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repositores{
    public interface IFormRepo
    {
         Task<IEnumerable<EnsayoCatedra>> GetFormA();
        Task<EnsayoCatedra> GetFormId( int id);
        Task<EnsayoCatedra?> Add(EnsayoCatedra ensayo);
        Task<EnsayoCatedra?> Modificar(EnsayoCatedra ensayo);
        Task<IActionResult> EliminarForm(int id);
    }
}
