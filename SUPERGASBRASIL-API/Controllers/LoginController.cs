using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUPERGASBRASIL_API.Dto;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Services.Interfaces.Token;

namespace SUPERGASBRASIL_API.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenService _token;

        public LoginController(ITokenService token)
        {
            _token = token;
        }

        /// <summary>
        /// Para obter o TOKEN
        /// </summary>
        [HttpPost("/authentication")]
        public IActionResult Login([FromForm] ModelOfLogin login)
        {
            try
            {
                var token = _token.GenerateToken(login);

                if (token == "")
                {
                    return Unauthorized();
                }

                return Ok(token);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro de criação por parte do servidor(Controller): {ex.Message}");
            }

        }
    }
}