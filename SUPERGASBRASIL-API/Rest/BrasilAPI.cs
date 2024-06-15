using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Interface;
using SUPERGASBRASIL_API.Rest.Model;
using System.Dynamic;
using System.Text.Json;

namespace SUPERGASBRASIL_API.Rest
{
    public class BrasilAPI : IBrasilAPI
    {
        public async Task<ResponseGenerico<CnpjModel>> BuscarCNPJ(string cnpj)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");

            var response = new ResponseGenerico<CnpjModel>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                var objResponse = JsonSerializer.Deserialize<CnpjModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }
}
