using System.ComponentModel.DataAnnotations;

namespace _28July.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]
        [StringLength(100, MinimumLength =5,ErrorMessage ="Product Name must be between 5 and 100")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Product price is Required")]
        [Range(10,100000,ErrorMessage ="Product Price Must be Between 10 and 100000")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product Qantity is Required")]
        [Range(10,100, ErrorMessage = "Product Quantity Must be Between 10 and 100")]
        public int Quantity { get; set; }

    }
}
