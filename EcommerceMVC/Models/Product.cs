using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Product                          //to make table and access data
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = " ";

        [MaxLength(100)]
        public string Brand { get; set; } = " ";

        [MaxLength(100)]
        public string Category { get; set; } = " ";
        [Precision(16,2)]
        public decimal Price { get; set; } 

        public string Description { get; set; } = " ";
        [MaxLength(100)]
        public string ImageFileName{ get; set; } = " ";
        public DateTime CreatedAt { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}

/*
public class Product
{
    // ... other properties
    public ImageFileDto ImageFile { get; set; }
}

public class ImageFileDto
{
    public string FileName { get; set; }
    public byte[] Content { get; set; }
    // ... other properties
}

// In OnModelCreating
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Product>()
        .HasOne(p => p.ImageFile)
        .WithOne()
        .HasForeignKey<ImageFileDto>(i => i.ProductId); // Assuming ProductId is the foreign key
}

*/

//////////////////
/*
 * using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models
{
    public class Product                          //to make table and access data
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = " ";

        [MaxLength(100)]
        public string Brand { get; set; } = " ";

        [MaxLength(100)]
        public string Category { get; set; } = " ";
        [Precision(16,2)]
        public decimal Price { get; set; } 

        public string Description { get; set; } = " ";
        [MaxLength(100)]
        public string ImageFileName{ get; set; } = " ";
        public DateTime CreatedAt { get; set; }
        public IFormFile? ImageFile { get; internal set; }

      
    }
}
 */