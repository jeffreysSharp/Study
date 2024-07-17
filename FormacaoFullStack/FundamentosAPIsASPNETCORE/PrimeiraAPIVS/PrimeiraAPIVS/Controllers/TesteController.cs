using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPIVS.Controllers
{
    [ApiController]
    [Route("api/demo")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new Produto { Id = 1, Nome = "Jeferson Especialista em .NET" });
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Teste" });
        }
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            return CreatedAtAction("Get", new { id = produto.Id }, produto);
        }

        [HttpPut("id")]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id) return BadRequest();
            return NoContent();
        }

        [HttpDelete("id:int")]
        public IActionResult Delete(int id)
        { 
            return NoContent(); 
        }


    }
}
