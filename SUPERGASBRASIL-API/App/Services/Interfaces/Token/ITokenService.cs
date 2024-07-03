using SUPERGASBRASIL_API.App.Dto;

namespace SUPERGASBRASIL_API.App.Services.Interfaces.Token
{
    public interface ITokenService
    {
        public string GenerateToken(ModelOfLogin login);
    }
}
