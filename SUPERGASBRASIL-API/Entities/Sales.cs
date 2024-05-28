using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Entities.GasStock;
using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Entities
{
    public class Sales
    {
        public Guid IdSales { get; set; }
        public Guid ?IdClient { get; set; }
        public int Quantity { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TypeOfGas Type { get; set; }
        public DateTime TimeOfSale { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
