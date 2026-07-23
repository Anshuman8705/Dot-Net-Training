using System.ComponentModel.DataAnnotations;

namespace _22july.Models
{
    public class Stationery
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }

        [Range(1, 1000, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Range(1, 10000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }
    }
}