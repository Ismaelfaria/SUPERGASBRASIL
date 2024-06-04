using SUPERGASBRASIL_API.Entities.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Entities
{
    public class User
    {
        public User()
        {
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ERole Role { get; set; }
        public string Roles { get; set; }
        public bool IsDeleted { get; set; }

        public void Deletar()
        {
            IsDeleted = true;
        }
    }
}
