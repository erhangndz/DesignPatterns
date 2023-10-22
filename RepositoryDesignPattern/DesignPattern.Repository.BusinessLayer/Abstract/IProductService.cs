using DesignPattern.Repository.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> GetAll();
    }
}
