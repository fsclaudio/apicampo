using System;
using apicampo.Models;
using apicampo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apicampo.Controllers
{
     [Authorize]
     [ApiController]
     [Route("variaveis")]
    public class VariaveisController : ControllerBase
    {
        [HttpGet]
        public IActionResult Read([FromServices] IVariaveisRepository repository){
            //var id = new Guid(User.Identity.Name);
            var variaveis = repository.Read();
            return Ok(variaveis);
        }
        [HttpPost]
        public IActionResult Create([FromBody]Variaveis model , [FromServices]IVariaveisRepository repository)
        {
            if (!ModelState.IsValid)
              return BadRequest();
              //model.UsuarioId = new Guid(User.Identity.Name);
            repository.Create(model);
            return Ok();  
        } 
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody]Variaveis model , [FromServices]IVariaveisRepository repository)
        {
            if (!ModelState.IsValid)
              return BadRequest();
               
            repository.Update(new Guid(id), model);
            return Ok();  
        } 

         [HttpDelete("{id}")]
        public IActionResult Delete(string id, [FromServices]IVariaveisRepository repository)
        {              
            repository.Delete(new Guid(id));
            return Ok();  
        } 
    }
    
}