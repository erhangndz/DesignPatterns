using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CompositeDesignPattern.DataAccess
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
