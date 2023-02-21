using Microsoft.AspNetCore.Mvc;
using NegosudAPI.Services.AuthentificationService;
using System.Security.Claims;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnexionController : ControllerBase
    {

        private readonly IJwtAuthentificationService _jwtAuthentificationService;
        private readonly IConfiguration _config;

        public ConnexionController(IJwtAuthentificationService jwtAuthentificationService, IConfiguration config)
        {
            _jwtAuthentificationService = jwtAuthentificationService;
            _config = config;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginModel request)
        {
            var client = await _jwtAuthentificationService.Login(request.Email, request.MotDePasse);

            if (client == null)
            {
                return BadRequest("Invalid email or password");
            }

            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, client.Email),
                };
            var token = _jwtAuthentificationService.GenerateToken(_config["Jwt:Key"], claims);
            return Ok(new { token });
        }
    }
}
