using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/formacionacademica")]
    [ApiController]
    public class GIUController : ControllerBase
    {
         private readonly IUnitOfWork unitOfWork;
         
         public GIUController(IUnitOfWork unitOfWork)
        {
             this.unitOfWork = unitOfWork;
         }

         [HttpGet]           //Devuelve todas la formaciones academicas
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetFormA()
         {
             try
            {
                return (await this.unitOfWork.FormRepo.GetFormA()).ToList();
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

         [HttpGet("{id:int}")] //Buscar por id
         public async Task<ActionResult<FormacionAcademica>> GetFormacionAcademicaId(int id)
         {
             try
             {
                 var result = await unitOfWork.FormRepo.GetFormacionAcademicaId(id);
             
                 if (result == null)
                {

                    return NotFound($"No hay ofertas activas para el proveedor con id:{id}");
                }

                return Ok(result);
             }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from database");
            }
         }
     
       [HttpPost]

            public async Task<ActionResult<FormacionAcademica>> Create(FormacionAcademica oferta)
            {
            try
            {
                if (oferta == null)
                    return BadRequest();

                var createdEmployee = await unitOfWork.FormRepo.Add(oferta);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetFormA),
                    new { id = createdEmployee?.Id }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
         
      [HttpPut("{id}")]
        public async Task<ActionResult<FormacionAcademica?>> Modificar(int id, FormacionAcademica formacionAcademica)
        {
            try
            {
                if (id != formacionAcademica.Id)
                    return BadRequest("Proveedor ID mismatch");

                var proveedorToUpdate = await unitOfWork.FormRepo.GetFormacionAcademicaId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"Proveedor with Id = {id} not found");

                return await unitOfWork.FormRepo.Modificar(formacionAcademica);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<FormacionAcademica?>> EliminarForm(int id)
    {
        try
        {
            var eliminar = await unitOfWork.FormRepo.GetFormacionAcademicaId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró formacion academica con Id = {id}");
            }

            return Ok(await unitOfWork.FormRepo.EliminarForm(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }
        
    
    }
}