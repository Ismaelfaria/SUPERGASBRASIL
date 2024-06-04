using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.Token
{
    public interface ITokenService
    {
        public string GenerateToken(User login);
    }
}
