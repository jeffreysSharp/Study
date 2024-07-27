using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPIVS.Controllers
{
    [ApiController]
    [Route("[api/minha-controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {

        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id:int}/dado/{id2:}")]
        public IActionResult Get2(int Id, int Id2)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Get3()
        {
            return Ok();
        }



    }
}