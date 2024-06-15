using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Interface;
using SUPERGASBRASIL_API.Rest.Model;

namespace SUPERGASBRASIL_API.Rest
{
    public class CnpjService : ICnpjService
    {
        private readonly IBrasilAPI _brasilApi;

        public CnpjService(IBrasilAPI brasilApi)
        {
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj)
        {
            var RespCnpj = await _brasilApi.BuscarCNPJ(cnpj);
            return RespCnpj;
        }
    }
}
