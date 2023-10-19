using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Observer.DataAccess
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=DbObserverPattern;integrated security=true");
        }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }

    }
}
