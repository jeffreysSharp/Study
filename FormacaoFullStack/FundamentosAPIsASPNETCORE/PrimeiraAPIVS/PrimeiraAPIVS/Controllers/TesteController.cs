using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPIVS.Controllers
{
    [ApiController]
    [Route("api/demo")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(new Produto { Id = 1, Nome = "Jeferson Especialista em .NET" });
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(new Produto { Id = 1, Nome = "Teste" });
        }

        [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(Produto produto)
        {
            return CreatedAtAction("Get", new { id = produto.Id }, produto);
        }

        [HttpPut("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, Produto produto)
        {
            if (id != produto.Id) return BadRequest();
            return NoContent();
        }

        [HttpDelete("id:int")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(int id)
        { 
            return NoContent(); 
        }


    }
}
