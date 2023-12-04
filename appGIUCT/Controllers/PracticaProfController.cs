using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace PracticaProfManagment.Ap.Controllers
{
    [Route("api/PracticaProfesionalizante")]
    [ApiController]
    public class PracticaProfController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PracticaProfController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]          //Devuelve todas la formaciones academicas
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetFormA()
         {
             try
            {
                return (await this.unitOfWork.practicaProfesionalizanteRepo.GetPracticaProfesionalizante()).ToList();
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PracticaProfesionalizante>> GetPractId(int id)
        {
             try
             {
                 var result = await unitOfWork.practicaProfesionalizanteRepo.GetPracticaProfesionalizanteId(id);
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

            public async Task<ActionResult<PracticaProfesionalizante?>> Create(PracticaProfesionalizante practica)
            {
            try
            {
                if (practica == null)
                    return BadRequest();

                var crearEnsayo = await unitOfWork.practicaProfesionalizanteRepo.Add(practica);
                await unitOfWork.CompleteAsync();

                return CreatedAtAction(nameof(GetPractId),
                    new { id = crearEnsayo?.Id }, crearEnsayo);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PracticaProfesionalizante?>> Modificar(int id, PracticaProfesionalizante practica)
        {
            try
            {
                if (id != practica.Id)
                    return BadRequest("Practica Profesionalizante ID mismatch");

                var proveedorToUpdate = await unitOfWork.practicaProfesionalizanteRepo.GetPracticaProfesionalizanteId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"No se encontro Practica Profesionalizante con id {id}");

                return await unitOfWork.practicaProfesionalizanteRepo.Modificar(practica);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        

        [HttpDelete("{id:int}")]
    public async Task<ActionResult<PracticaProfesionalizante?>> EliminarForm(int id)
    {
        try
        {
            var eliminar = await unitOfWork.practicaProfesionalizanteRepo.GetPracticaProfesionalizanteId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró ensayo con Id = {id}");
            }

            return Ok(await unitOfWork.practicaProfesionalizanteRepo.EliminarPracticaProfesionalizante(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    }
}