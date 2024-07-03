using SUPERGASBRASIL_API.App.Rest.DTO;
using SUPERGASBRASIL_API.App.Rest.Model;

namespace SUPERGASBRASIL_API.App.Rest.Interface
{
    public interface IBrasilAPI
    {
        Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj);
    }
}
