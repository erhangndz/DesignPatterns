using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Repository.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {

        void TDelete(int id);
        void TUpdate(T entity);
        void TInsert(T entity);
        List<T> TGetList();
        T TGetById(int id);
    }
}
