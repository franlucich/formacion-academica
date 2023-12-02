using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repositores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/formacionacademica")]
    [ApiController]
    public class EnsayoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EnsayoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("{ensayocatedra}")]          //Devuelve todas la formaciones academicas
         
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

        [HttpGet("{ensayocatedra}/{id:int}")]
        public async Task<ActionResult<EnsayoCatedra>> GetFromId(int id)
        {
             try
             {
                 var result = await unitOfWork.FormRepo.GetFormId(id);
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

                var crearEnsayo = await unitOfWork.FormRepo.Add(ensayo);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetFormA),
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

                var proveedorToUpdate = await unitOfWork.FormRepo.GetFormId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"Proveedor with Id = {id} not found");

                return await unitOfWork.FormRepo.Modificar(ensayo);
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
            var eliminar = await unitOfWork.FormRepo.GetFormId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró ensayo con Id = {id}");
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