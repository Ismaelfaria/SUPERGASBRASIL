using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Model;

namespace SUPERGASBRASIL_API.Rest.Interface
{
    public interface IBrasilAPI
    {
        Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj);
    }
}
