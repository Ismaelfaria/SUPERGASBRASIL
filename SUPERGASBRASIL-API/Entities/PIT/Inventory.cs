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
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        public void UpdateInventory(Guid idProduct, Product product, int quantity)
        {
            IdProduct = idProduct;
            Product = product;
            Quantity = quantity;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
