using Microsoft.EntityFrameworkCore;

namespace DesignPattern.MediatorDesign.DataAccess
{
    public class Context:DbContext
    {

        public Context(DbContextOptions options):base(options) { }
       
        public DbSet<Product> Products { get; set; }
    }
}
