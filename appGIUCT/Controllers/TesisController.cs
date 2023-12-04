using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/tesisPosgrado")]
    [ApiController]
    public class TesisController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public TesisController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
         
         public async Task<ActionResult<IEnumerable<FormacionAcademica>>> GetFormA()
         {
             try
            {
                return (await this.unitOfWork.tesisPosgrado.GetTesisPosgrado()).ToList();
                
            }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
             }
         }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TesisPosgrado>> GetTesisId(int id)
        {
             try
             {
                 var result = await unitOfWork.tesisPosgrado.GetTesisPosgradoId(id);
                 if (result == null) return NotFound("No se encontro tesis con ese Id");

                 return result;
             }
             catch (Exception)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
             }
        }

        [HttpPost]

           [HttpPost]

            public async Task<ActionResult<TesisPosgrado>> Create([FromBody]TesisPosgrado tesis)
            {
            try
            {
                if (tesis == null)
                    return BadRequest("No match");

                var tesisP = await unitOfWork.tesisPosgrado.Add(tesis);
                return CreatedAtAction(nameof(GetTesisId),
                    new { id = tesisP.Id }, tesisP);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<TesisPosgrado?>> Modificar(int id, TesisPosgrado tesis)
        {
            try
            {
                if (id != tesis.Id)
                    return BadRequest("Tesis ID mismatch");

                var proveedorToUpdate = await unitOfWork.tesisPosgrado.GetTesisPosgradoId(id);

                if (proveedorToUpdate == null)
                    return NotFound($"Tesis with Id = {id} not found");

                return await unitOfWork.tesisPosgrado.Modificar(tesis);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }
        

        [HttpDelete("{id:int}")]
    public async Task<ActionResult<TesisPosgrado?>> EliminarForm(int id)
    {
        try
        {
            var eliminar = await unitOfWork.tesisPosgrado.GetTesisPosgradoId(id);

            if (eliminar == null)
            {
                return NotFound($"No se encontró tesis con Id = {id}");
            }

            return Ok(await unitOfWork.tesisPosgrado.EliminarTesisPosgrado(id));             
        }

        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    }
}