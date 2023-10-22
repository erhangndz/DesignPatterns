using DesignPattern.Repository.BusinessLayer.Abstract;
using DesignPattern.Repository.DataAccessLayer.Abstract;
using DesignPattern.Repository.DataAccessLayer.Concrete;
using DesignPattern.Repository.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.BusinessLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IGenericDal<Product> _productDal;
        private readonly Context _context;

        public ProductService(IGenericDal<Product> productDal, Context context)
        {
            _productDal = productDal;
            _context = context;
        }

        public List<Product> GetAll()
        {
           return _context.Products.Include(x=>x.Category).ToList();
        }

        public void TDelete(int id)
        {
           _productDal.Delete(id);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
           _productDal.Update(entity);
        }
    }
}
