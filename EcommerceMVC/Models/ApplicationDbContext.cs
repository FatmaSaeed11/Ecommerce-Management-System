using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Models
{
    public class ApplicationDbContext : DbContext        //connect project with SQL 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)   //constructor
        {

        }


        public DbSet<Product> Products { get; set; }    //property dbset for class product and for db table and then cteate migration
    }
}
