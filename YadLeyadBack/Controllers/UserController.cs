using Appilcation.Interfaces;
using Appilcation.Models;
using Microsoft.AspNetCore.Mvc;

namespace YadLeyadBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private IConfiguration _config;
        public UserController(IUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }
        [HttpPost]
        [Route("registration")]
        public async Task<IActionResult> AddUser([FromBody] RegistrationModelRequest userReq)
        {
            try
            {
                var userCreated = await _userService.AddUserAsync(userReq);
                return Ok("יוזר נוצר בהצלחה");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModelRequest loginReq)
        {
            try
            {
                string userAuthenticate = await _userService.Login(loginReq);
                return Ok(userAuthenticate);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
