using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repositores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/formacionacademica")]
    [ApiController]
    public class TesinaController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public TesinaController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("{tesina}")]          //Devuelve todas la formaciones academicas
         
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

        [HttpGet("{tesina}/{id:int}")]
        public async Task<ActionResult<TesinaLicenciatura>> GetFromId(int id)
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

            public async Task<ActionResult<TesinaLicenciatura>> Create(TesinaLicenciatura tesina)
            {
            try
            {
                if (tesina == null)
                    return BadRequest();

                var crearTesina = await unitOfWork.FormRepo.Add(tesina);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetFormA),
                    new { id = crearTesina?.Id }, crearTesina);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TesinaLicenciatura?>> Modificar(int id, TesinaLicenciatura tesina)
        {
            try
            {
                if (id != tesina.Id)
                    return BadRequest("Proveedor ID mismatch");

                var tesinaToUpdate = await unitOfWork.FormRepo.GetFormId(id);

                if (tesinaToUpdate == null)
                    return NotFound($"Proveedor with Id = {id} not found");

                return await unitOfWork.FormRepo.Modificar(tesina);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        

        [HttpDelete("{id:int}")]
    public async Task<ActionResult<TesinaLicenciatura?>> EliminarForm(int id)
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