using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Model;

namespace SUPERGASBRASIL_API.Rest
{
    public interface ICnpjService
    {
        Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj);

    }
}
