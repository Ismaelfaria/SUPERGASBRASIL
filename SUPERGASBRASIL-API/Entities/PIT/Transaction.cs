using SUPERGASBRASIL_API.Entities.Enum;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Entities.PIT
{
    public class Transaction
    {
        public Transaction()
        {
            IsDeleted = false;
        }
        public Guid IdTransaction { get; set; }
        public Guid IdProduct { get; set; }
        public Product Product { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TransactionINorOUT Type { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
