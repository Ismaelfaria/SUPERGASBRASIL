using Microsoft.IdentityModel.Tokens;
using SUPERGASBRASIL_API.App.Dto;
using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.App.Services.Interfaces.Token;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SUPERGASBRASIL_API.App.Services.ServicesImplementation.Token
{
    public class TokenService : ITokenService
    {

        public readonly IConfiguration _configuration;
        public readonly IUserRepository _userRepository;

        public TokenService(
            IConfiguration configuration,
            IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }

        public string GenerateToken(ModelOfLogin login)
        {
            var userDatabase = _userRepository.FindByUserName(login.Username);

            if (userDatabase == null)
            {
                return string.Empty;
            }

            var secretyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];

            var signingCredentials = new SigningCredentials(secretyKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: new Claim[]
                {
                    new Claim(ClaimTypes.Name, userDatabase.Username),
                    new Claim(ClaimTypes.Role, userDatabase.Roles),
                },
                expires: DateTime.Now.AddHours(2),
                signingCredentials: signingCredentials
                );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return token;
        }
    }
}
