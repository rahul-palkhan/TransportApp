using CarTransportBack.Entity;
using CarTransportBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarTransportBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly IRideService _rideService;

        public RideController(IRideService rideService)
        {
            _rideService = rideService;
        }

        [HttpGet,Route("GetRides")]
        public IActionResult GetRides()
        {
            try
            {
                return Ok(_rideService.GetAllRides());
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet,Route("GetRide/{id}")]
        public IActionResult GetRide(int id)
        {
            try
            {
                Ride ride = _rideService.GetRide(id);
                if (ride != null)
                {
                    return Ok(ride);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpDelete,Route("DeleteRide/{id}")]
        public IActionResult DeleteRide(int id)
        {
            try
            {
                _rideService.Remove(id);
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPut,Route("AddRide")]
        public IActionResult AddRide(Ride ride)
        {
            try
            {
                _rideService.Add(ride);
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
