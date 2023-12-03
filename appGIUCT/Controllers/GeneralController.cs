using appGIUCT.Domain.Entities;
using appGIUCT.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;





namespace GeneralManagment.Ap.Controllers
{
    [Route("api/general")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly GIUCTDbContext gIUCTDbContext;

        public GeneralController(GIUCTDbContext gIUCTDbContext)
        {
            this.gIUCTDbContext = gIUCTDbContext;
        }

         [HttpGet("persona/{id:int}")]
        public async Task<ActionResult> GetPersonaId(int id)
        {

            var persona = await gIUCTDbContext.Person.Where(i => i.Id == id).ToListAsync();
	        return Ok(persona);
        }

         [HttpGet("persona")]
        public async Task<ActionResult> GetPersona()
        {

            var persona = await gIUCTDbContext.Person.ToListAsync();
	        return Ok(persona);
        }

        [HttpGet("facultad")]
        public async Task<ActionResult> GetFacultad()
        {

            var facu = await gIUCTDbContext.Facultad.ToListAsync();
	        return Ok(facu);
        }

         [HttpGet("facultad/{id:int}")]
        public async Task<ActionResult> GetFacultadId(int id)
        {

            var facu = await gIUCTDbContext.Facultad.Where(i => i.Id == id).ToListAsync();
	        return Ok(facu);
        }


        [HttpGet("pid")]
        public async Task<ActionResult> GetPid()
        {

            var pid = await gIUCTDbContext.Pid.ToListAsync();
	        return Ok(pid);
        }

         [HttpGet("pid/{id:int}")]
        public async Task<ActionResult> GetPidId(int id)
        {

            var pid = await gIUCTDbContext.Pid.Where(i => i.Id == id).ToListAsync();
	        return Ok(pid);
        }

        [HttpGet("Iniciativa")]
        public async Task<ActionResult> GetIniciativa()
        {

            var inic = await gIUCTDbContext.IniciativaDeInvestigacion.ToListAsync();
	        return Ok(inic);
        }

         [HttpGet("Iniciativa/{id:int}")]
        public async Task<ActionResult> GetIniciativaId(int id)
        {

            var inic = await gIUCTDbContext.IniciativaDeInvestigacion.Where(i => i.Id == id).ToListAsync();
	        return Ok(inic);
        }
        
        
    }

}