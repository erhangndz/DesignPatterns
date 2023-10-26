using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DataAccess
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=DbDecoratorPattern;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
