using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/ProyectoFinalIngenieria")]
    [ApiController]
    public class ProyFinontroller : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ProyFinontroller(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]          //Devuelve todas la formaciones academicas
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetFormA()
         {
             try
            {
                return (await this.unitOfWork.proyectoFinalIngenieria.GetProyectoFinalIngenieria()).ToList();
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProyectoFinalIngenieria>> GetProId(int id)
        {
             try
             {
                 var result = await unitOfWork.proyectoFinalIngenieria.GetProyectoFinalIngenieriaId(id);
                 if (result == null) return NotFound("No se encontro ensayo de catedra con ese Id");

                 return result;
             }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
             }
        }

        [HttpPost]

            public async Task<ActionResult<ProyectoFinalIngenieria?>> Create(ProyectoFinalIngenieria proyecto)
            {
                try
                {
                    if (proyecto == null)
                        return BadRequest();

                    var crearProyecto = await unitOfWork.proyectoFinalIngenieria.Add(proyecto);
                    await unitOfWork.CompleteAsync();

                    return CreatedAtAction(nameof(GetFormA),
                        new { id = crearProyecto?.Id }, crearProyecto);
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error creating new employee record");
                }
            }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProyectoFinalIngenieria?>> Modificar(int id, ProyectoFinalIngenieria proyecto)
        {
            try
            {
                if (id != proyecto.Id)
                    return BadRequest("Proveedor ID mismatch");

                var proveedorToUpdate = await unitOfWork.proyectoFinalIngenieria.GetProyectoFinalIngenieriaId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"Proveedor with Id = {id} not found");

                return await unitOfWork.proyectoFinalIngenieria.Modificar(proyecto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        

        [HttpDelete("{id:int}")]
    public async Task<ActionResult<ProyectoFinalIngenieria?>> EliminarForm(int id)
    {
        try
        {
            var eliminar = await unitOfWork.proyectoFinalIngenieria.GetProyectoFinalIngenieriaId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró ensayo con Id = {id}");
            }

            return Ok(await unitOfWork.proyectoFinalIngenieria.EliminarProyectoFinalIngenieria(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    }
}