using Microsoft.IdentityModel.Tokens;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces.Token;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.Token
{
    public class TokenService : ITokenService
    {

        public readonly IConfiguration _configuration;
        public readonly IUserRepository _userRepository;

        public TokenService(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public string GenerateToken(User login)
        {
            var userDatabase = _userRepository.FindByUserName(login.Username);

            if (userDatabase.Username == login.Username && userDatabase.Password == login.Password)
            {
                return string.Empty;
            }

            var secretyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration[""]));
            var issuer = _configuration[""];
            var audience = _configuration[""];

            var signingCredentials = new SigningCredentials(secretyKey, SecurityAlgorithms.HmacSha256);

            var tokenOption = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: new[]
                {
                    new Claim(ClaimTypes.Name, userDatabase.Username),
                    new Claim(ClaimTypes.Role, userDatabase.Roles),
                },
                expires: DateTime.Now.AddHours(2),
                signingCredentials: signingCredentials);

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOption);

            return token;
        }
    }
}
