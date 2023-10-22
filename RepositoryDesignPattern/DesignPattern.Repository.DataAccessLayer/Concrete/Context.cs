using DesignPattern.Repository.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options) { }
        

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
            
        
    }
}
