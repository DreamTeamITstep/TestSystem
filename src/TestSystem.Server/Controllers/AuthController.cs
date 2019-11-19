using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestSystem.Common;
using TestSystem.Server.Services;

namespace TestSystem.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController: ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginRequest loginRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { Message = "Bad request format" });
            }
            var token = _authService.Authenticate(loginRequest.Login, loginRequest.Password);

            if (token == null)
            {
                return NotFound(new { Message = "User or password is incorrect" });
            }

            return Ok(token);
        }
    }
}
