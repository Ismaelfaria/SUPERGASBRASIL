using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Entities.PIT
{
    public class Inventory
    {
        public Inventory()
        {
            IsDeleted = false;
        }
        public Guid IdInventory { get; set; }
        public Guid IdProduct { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public string? NameProduct { get; set; }
        [JsonIgnore]
        public Product? Product { get; set; }
        public bool IsDeleted { get; set; }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
