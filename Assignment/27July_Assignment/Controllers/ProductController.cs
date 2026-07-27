using _27July.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _27July_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products = new List<Product>()
        {
             new Product() {Id = 001, Name ="Pen" , Category ="Sationary" , Brand = "Apsara", Price = 5.00, Quantity = 30},
             new Product(){Id = 002 , Name = "Book", Category = "Sationary", Brand = "ClassMate", Price = 80.00, Quantity = 50},
             new Product() {Id = 003, Name = "Laptop", Category = "Electronics", Brand = "Acer", Price = 80000, Quantity = 10}
        };

        // to Get products 
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products); // 200
        }

        // to Get Products By Id 
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound("Product Not Found");
            }
            return Ok(product);
        }

        // to post (insert data of Products) 
        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            products.Add(product);
            return Ok(product);
        }

        // to add new data by id 
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existingProduct = products.FirstOrDefault(x => x.Id == id);
            if (existingProduct == null)
                return NotFound("Product not found");

            existingProduct.Name = product.Name;
            existingProduct.Category = product.Category;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.Brand = product.Brand;

            return Ok(existingProduct);
        }

        // to Delete Product by Id 
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound("Product not found");

            products.Remove(product);
            return Ok($"Product with Id {id} deleted successfully");
        }

        // Search by Category 
        [HttpGet("Category/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {
            var result = products.Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!result.Any())
            {
                return NotFound("No Such Product");
            }
            return Ok(result);
        }
    }
}
