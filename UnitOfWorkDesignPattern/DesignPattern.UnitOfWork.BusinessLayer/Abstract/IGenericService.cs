using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> TGetList();
        T TGetById(int id);
        void TMultiUpdate(List<T> entity);
    }
}
