using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IPracticaSupervisadaIngenieria
    {
        Task<IEnumerable<PracticaSupervisadaIngenieria>> GetPracticaSupervisadaIngenieria();
        Task<PracticaSupervisadaIngenieria?> GetPracticaSupervisadaIngenieriaId( int idP);
        Task<PracticaSupervisadaIngenieria> Add(PracticaSupervisadaIngenieria practicaSupervisadaIngenieria);
        Task<PracticaSupervisadaIngenieria> Modificar(PracticaSupervisadaIngenieria practicaSupervisadaIngenieria);
        Task<IActionResult> EliminarPracticaSupervisadaIngenieria(int id);
    }
}