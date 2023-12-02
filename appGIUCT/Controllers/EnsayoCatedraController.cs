using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/ensayoCatedra")]
    [ApiController]
    public class EnsayoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EnsayoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]          //Devuelve todas la formaciones academicas
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetEnsayo()
         {
             try
            {
                return (await this.unitOfWork.ensayoCatedraRepo.GetEnsayoCatedra()).ToList();
            
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EnsayoCatedra>> GetEnsayoId(int id)
        {
             try
             {
                 var result = await unitOfWork.ensayoCatedraRepo.GetEnsayoCatedraId(id);
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

            public async Task<ActionResult<EnsayoCatedra>> Create(EnsayoCatedra ensayo)
            {
            try
            {
                if (ensayo == null)
                    return BadRequest();

                var crearEnsayo = await unitOfWork.ensayoCatedraRepo.Add(ensayo);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetEnsayo),
                    new { id = crearEnsayo?.Id }, crearEnsayo);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EnsayoCatedra?>> Modificar(int id, EnsayoCatedra ensayo)
        {
            try
            {
                if (id != ensayo.Id)
                    return BadRequest("Proveedor ID mismatch");

                var proveedorToUpdate = await unitOfWork.ensayoCatedraRepo.GetEnsayoCatedraId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"Proveedor with Id = {id} not found");

                return await unitOfWork.ensayoCatedraRepo.Modificar(ensayo);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        

        [HttpDelete("{id:int}")]
    public async Task<ActionResult<EnsayoCatedra?>> EliminarForm(int id)
    {
        try
        {
            var eliminar = await unitOfWork.ensayoCatedraRepo.GetEnsayoCatedraId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró ensayo con Id = {id}");
            }

            return Ok(await unitOfWork.ensayoCatedraRepo.EliminarEnsayoCatedra(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    }
}