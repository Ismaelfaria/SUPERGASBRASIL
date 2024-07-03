using SUPERGASBRASIL_API.Domain.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.App.Mapping.Models.InputModel
{
    public class User_InputModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ERole Role { get; set; }
    }
}
