using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IProyectoFinalIngenieria
    {
        Task<IEnumerable<ProyectoFinalIngenieria>> GetProyectoFinalIngenieria();
        Task<ProyectoFinalIngenieria?> GetProyectoFinalIngenieriaId( int idP);
        Task<ProyectoFinalIngenieria> Add(ProyectoFinalIngenieria proyectoFinalIngenieria);
        Task<ProyectoFinalIngenieria> Modificar(ProyectoFinalIngenieria proyectoFinalIngenieria);
        Task<IActionResult> EliminarProyectoFinalIngenieria(int id);
    }
}