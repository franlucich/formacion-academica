using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IFormRepo
    {
        Task<IEnumerable<FormacionAcademica>> GetFormA();
        Task<FormacionAcademica?> GetFormacionAcademicaId( int idP);
        Task<FormacionAcademica> Add(FormacionAcademica formacionAcademica);
        Task<FormacionAcademica> Modificar(FormacionAcademica formacionAcademica);
        Task<IActionResult> EliminarForm(int id);
    }
}