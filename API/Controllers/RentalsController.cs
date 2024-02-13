using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class RentalsController : ControllerBase
    {
        [HttpPost("{id}")]
        [Authorize("MinimumAge")]
        public IActionResult RentCar(int carId)
        {
            // Logic to implement car rental
            return Ok("Rented");
        }
    }
}
