using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OData.API.Services;

namespace OData.API.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet("api/cars")]
        [EnableQuery]
        public IActionResult GetCars()
        {
            var service = new CarService();

            return Ok(service.GetCars());
        }
    }
}
