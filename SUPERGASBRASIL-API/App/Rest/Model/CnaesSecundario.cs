using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.App.Rest.Model
{
    public class CnaesSecundario
    {
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string? Descricao { get; set; }
    }
}
