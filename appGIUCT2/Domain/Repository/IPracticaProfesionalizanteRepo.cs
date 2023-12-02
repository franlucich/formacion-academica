using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IPracticaProfesionalizanteRepo
    {
        Task<IEnumerable<PracticaProfesionalizante>> GetPracticaProfesionalizante();
        Task<PracticaProfesionalizante?> GetPracticaProfesionalizanteId( int idP);
        Task<PracticaProfesionalizante> Add(PracticaProfesionalizante practicaProfesionalizante);
        Task<PracticaProfesionalizante> Modificar(PracticaProfesionalizante practicaProfesionalizante);
        Task<IActionResult> EliminarPracticaProfesionalizante(int id);
    }
}