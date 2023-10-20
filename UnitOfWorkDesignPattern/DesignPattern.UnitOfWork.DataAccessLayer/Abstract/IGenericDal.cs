using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetList();
        T GetById(int id);
        void MultiUpdate(List<T> entity);
    }
}
