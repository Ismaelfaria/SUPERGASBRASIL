using SUPERGASBRASIL_API.App.Rest.DTO;
using SUPERGASBRASIL_API.App.Rest.Interface;
using SUPERGASBRASIL_API.App.Rest.Model;

namespace SUPERGASBRASIL_API.App.Rest
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
