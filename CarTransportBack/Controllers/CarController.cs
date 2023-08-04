using CarTransportBack.Entity;
using CarTransportBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarTransportBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }
        [HttpPut,Route("AddCar")]
        public IActionResult AddCar(Car car)
        {
            try
            {
                carService.Add(car);
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet,Route("GetCar/{id}")]
        public IActionResult GetCar(int id)
        {
            try
            {
                return Ok(carService.GetCar(id));
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpGet,Route("GetAllCars")]
        public IActionResult GetAllCars()
        {
            try
            {
                return Ok(carService.GetCars());
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
