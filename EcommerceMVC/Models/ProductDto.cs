
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceMVC.Models
{
    public class ProductDto
    {
        [Required,MaxLength(100)]        //attribute
        public string Name { get; set; } = " ";

        [Required,MaxLength(100)]
        public string Brand { get; set; } = " ";

        [Required,MaxLength(100)]
        public string Category { get; set; } = " ";
        [Required]
        public decimal Price { get; set; } 
        [Required]
        public string Description { get; set; } = " ";
        //[NotMapped]
        public IFormFile? ImageFile { get; set; } //optional property when update and permenent when create
    }


}
