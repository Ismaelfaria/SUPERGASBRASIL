using SUPERGASBRASIL_API.Entities.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class Login_InputModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ERole Role { get; set; }
    }
}
