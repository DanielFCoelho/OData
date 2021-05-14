using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataExpand.API.Services;

namespace ODataExpand.API.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet("api/cars")]
        [EnableQuery]
        public IActionResult GetCars([FromServices] ICarService service)
        {
            return Ok(service.GetCars());
        }
    }
}
