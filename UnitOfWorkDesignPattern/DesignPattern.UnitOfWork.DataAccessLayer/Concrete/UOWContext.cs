using DesignPattern.UnitOfWork.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.DataAccessLayer.Concrete
{
    public class UOWContext:DbContext
    {
        public UOWContext(DbContextOptions options):base(options) { }
      

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processs { get; set; }    
    }
}
