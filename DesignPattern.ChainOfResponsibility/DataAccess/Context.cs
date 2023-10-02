using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DataAccess
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=ChainofRespDb;integrated security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
