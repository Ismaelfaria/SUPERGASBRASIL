using SUPERGASBRASIL_API.App.Rest.DTO;
using SUPERGASBRASIL_API.App.Rest.Model;

namespace SUPERGASBRASIL_API.App.Rest
{
    public interface ICnpjService
    {
        Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj);

    }
}
