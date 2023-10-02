using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DataAccess
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=CQRSDesignPatDb;integrated security=true");
        }


        public DbSet<Product> Products { get; set; }
    }
}
