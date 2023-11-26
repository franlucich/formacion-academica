using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repositores;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;





namespace ProveedorManagment.Ap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ProveedorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]

        public async Task<ActionResult> GetFormA()
        {
            try
            {
                return Ok(await this.unitOfWork.FormRepo.GetFormA());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
            }
        }
        //  [HttpGet("{id:int}")]
        // public async Task<ActionResult<Proveedor>> Get(int id)
        // {
        //     try
        //     {
        //         var result = await unitOfWork.Proveedors.GetProveedor(id);
        //         if (result == null) return NotFound("No se encontro proveedor con ese Id");

        //         return result;
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error retrieving data from the database");
        //     }
        // }

        // [HttpPost]
        // public async Task<ActionResult<Proveedor>> Create(Proveedor proveedor)
        // {
        //     try
        //     {
        //         if (proveedor == null)
        //             return BadRequest();

        //         var createdProveedor = await unitOfWork.Proveedors.Add(proveedor);
        //         await unitOfWork.CompleteAsync();

        //         return CreatedAtAction(nameof(Get),
        //             new { id = createdProveedor.Id }, createdProveedor);
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error al crear un nuevo proveedor");
        //     }
        // }
        //    [HttpPut("{id}")]
        // public async Task<ActionResult<Proveedor?>> Modificar(int id, Proveedor proveedor)
        // {
        //     try
        //     {
        //         if (id != proveedor.Id)
        //             return BadRequest("Proveedor ID mismatch");

        //         var proveedorToUpdate = await unitOfWork.Proveedors.GetProveedor(id);

        //         if (proveedorToUpdate == null)
        //             return NotFound($"Proveedor with Id = {id} not found");

        //         return await unitOfWork.Proveedors.Update(proveedor);
        //     }
        //     catch (Exception)
        //     {
        //         return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error updating data");
        //     }

//        }
    }
}