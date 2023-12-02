using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface ITesinaLicenciaturaRepo
    {
        Task<IEnumerable<TesinaLicenciatura>> GetTesinaLicenciatura();
        Task<TesinaLicenciatura?> GetTesinaLicenciaturaId( int idP);
        Task<TesinaLicenciatura> Add(TesinaLicenciatura tesinaLicenciatura);
        Task<TesinaLicenciatura> Modificar(TesinaLicenciatura tesinaLicenciatura);
        Task<IActionResult> EliminarTesinaLicenciatura(int id);
    }
}