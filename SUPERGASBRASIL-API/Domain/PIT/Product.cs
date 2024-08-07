﻿using System.Text.Json.Serialization;

namespace SUPERGASBRASIL_API.Domain.PIT
{
    public class Product
    {
        public Product()
        {
            IsDeleted = false;
        }
        public Guid IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        [JsonIgnore]
        public Inventory? Inventoryy { get; set; }
        public bool IsDeleted { get; set; }

        public void UpdateProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            UpdatedAt = DateTime.UtcNow;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
