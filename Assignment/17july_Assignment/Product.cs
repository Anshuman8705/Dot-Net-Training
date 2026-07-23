using System;

namespace ShopEaseApp
{
    // Module 2 - Product Management
    // Simple class to hold product details
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public double Discount { get; set; }
        public double Rating { get; set; }

        public Product(int productId, string name, string category, string description,
                        double price, int quantity, string brand, double discount, double rating)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Quantity = quantity;
            Brand = brand;
            Discount = discount;
            Rating = rating;
        }

        public void Display()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Product Id   : " + ProductId);
            Console.WriteLine("Name         : " + Name);
            Console.WriteLine("Category     : " + Category);
            Console.WriteLine("Description  : " + Description);
            Console.WriteLine("Price        : Rs. " + Price);
            Console.WriteLine("Quantity     : " + Quantity);
            Console.WriteLine("Brand        : " + Brand);
            Console.WriteLine("Discount     : " + Discount + "%");
            Console.WriteLine("Rating       : " + Rating);
        }
    }
}
