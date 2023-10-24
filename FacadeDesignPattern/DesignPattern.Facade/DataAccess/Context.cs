using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Facade.DataAccess
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options) { }
        

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

            
        
    }
}
