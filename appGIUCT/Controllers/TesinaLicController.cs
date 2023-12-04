using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/TesinaLicenciatura")]
    [ApiController]
    public class TesinaController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public TesinaController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]          //Devuelve todas la formaciones academicas
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetTesina()
         {
             try
            {
                return (await this.unitOfWork.tesinaLicenciatura.GetTesinaLicenciatura()).ToList();
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TesinaLicenciatura>> GetTesinaId(int id)
        {
             try
             {
                 var result = await unitOfWork.tesinaLicenciatura.GetTesinaLicenciaturaId(id);
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

            public async Task<ActionResult<TesinaLicenciatura?>> Create(TesinaLicenciatura tesina)
            {
            try
            {
                if (tesina == null)
                    return BadRequest();

                var crearTesina = await unitOfWork.tesinaLicenciatura.Add(tesina);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetTesinaId),
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
                    return BadRequest("Tesina ID mismatch");

                var tesinaToUpdate = await unitOfWork.tesinaLicenciatura.GetTesinaLicenciaturaId(id);

                if (tesinaToUpdate == null)
                    return NotFound($"Tesina with Id = {id} not found");

                return await unitOfWork.tesinaLicenciatura.Modificar(tesina);
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
            var eliminar = await unitOfWork.tesinaLicenciatura.GetTesinaLicenciaturaId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró tesina con Id = {id}");
            }

            return Ok(await unitOfWork.tesinaLicenciatura.EliminarTesinaLicenciatura(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    public async Task<ActionResult<Facultad>> GetFacultad(int id)
        {
             try
             {
                 var result = await unitOfWork.tesinaLicenciatura.GetFacultad(id);
                 if (result == null) return NotFound("No se encontro tesina con ese Id");

                 return result;
             }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
             }
        }
    }

}