using appGIUCT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace appGIUCT.Domain.Repository{
    public interface IProyectoFinalIngenieria
    {
        Task<IEnumerable<ProyectoFinalInenieria>> GetProyectoFinalInenieria();
        Task<ProyectoFinalInenieria?> GetProyectoFinalInenieriaId( int idP);
        Task<ProyectoFinalInenieria> Add(ProyectoFinalInenieria proyectoFinalInenieria);
        Task<ProyectoFinalInenieria> Modificar(ProyectoFinalInenieria proyectoFinalInenieria);
        Task<IActionResult> EliminarProyectoFinalInenieria(int id);
    }
}