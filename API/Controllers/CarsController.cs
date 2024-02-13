using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(Car.GetCars());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var car = Car.GetCarById(id);
            return car == null ? NotFound() : Ok(car);
        }

        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public IActionResult CreateCar(Car car)
        {
            Car.CreateCar(car);
            return Created("/createcar", car);
        }
    }
}
