using System.ComponentModel.DataAnnotations;

namespace _27July.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 100000, ErrorMessage = "Price must be greater than 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }
    }
}