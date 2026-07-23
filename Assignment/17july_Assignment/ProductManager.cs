using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopEaseApp
{
    // Module 2 - Product Management (Admin)
    // Handles add/update/delete/search/view all products
    public static class ProductManager
    {
        public static List<Product> Products = new List<Product>();
        private static int nextProductId = 1004; // 1001-1003 are used by sample data in Program.cs

        public static void AddProduct()
        {
            Console.WriteLine("\n--- Add Product ---");
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();

            Console.Write("Enter discount (%): ");
            double discount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rating (0-5): ");
            double rating = Convert.ToDouble(Console.ReadLine());

            Product newProduct = new Product(nextProductId, name, category, description,
                                              price, quantity, brand, discount, rating);
            Products.Add(newProduct);
            nextProductId++;

            Console.WriteLine("Product added successfully with Id: " + newProduct.ProductId);
        }

        public static void UpdateProduct()
        {
            Console.Write("\nEnter Product Id to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter new price (current: " + product.Price + "): ");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter new quantity (current: " + product.Quantity + "): ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new discount (current: " + product.Discount + "): ");
            product.Discount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Product updated successfully.");
        }

        public static void DeleteProduct()
        {
            Console.Write("\nEnter Product Id to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Products.Remove(product);
            Console.WriteLine("Product deleted successfully.");
        }

        public static void SearchProduct()
        {
            Console.Write("\nEnter product name or category to search: ");
            string keyword = Console.ReadLine().ToLower();

            var results = Products.Where(p => p.Name.ToLower().Contains(keyword) ||
                                               p.Category.ToLower().Contains(keyword)).ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            foreach (Product p in results)
                p.Display();
        }

        public static void ViewAllProducts()
        {
            Console.WriteLine("\n--- All Products ---");
            if (Products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (Product p in Products)
                p.Display();
        }
    }
}
