using DesignPattern.UnitOfWork.DataAccessLayer.Abstract;
using DesignPattern.UnitOfWork.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly UOWContext _context;

        public GenericRepository(UOWContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var values = _context.Set<T>().Find(id);
            _context.Remove(values);

        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void MultiUpdate(List<T> entity)
        {
            _context.Set<T>().UpdateRange(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
