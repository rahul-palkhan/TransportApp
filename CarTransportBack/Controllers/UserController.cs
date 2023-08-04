using CarTransportBack.Entity;
using CarTransportBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarTransportBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPut, Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            try
            {
                userService.Add(user);
                return Ok(user);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet,Route("GetUser/{id}")]
        public IActionResult GetUser(int id)
        {
            try
            {
                return Ok(userService.Get(id));
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
