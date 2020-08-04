using apicampo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apicampo.Controllers 
{
     [Authorize]
     [ApiController]
     [Route("Indica")]
    public class IncadoresController : ControllerBase{
         [HttpGet]   
        public IActionResult Read([FromServices] IIndicadoresRepository repository)
        {
            var indicadores = repository.Read();
            return Ok(indicadores);
        }
         [HttpGet ("{VARIA}")]
        public IActionResult Find(string varia, [FromServices]IIndicadoresRepository repository)
        {
            
           var indicadores = repository.Find(varia);  
           return Ok(indicadores);
        }

    }
}