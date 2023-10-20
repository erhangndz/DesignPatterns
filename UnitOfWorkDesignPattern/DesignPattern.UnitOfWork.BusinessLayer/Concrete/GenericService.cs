using DesignPattern.UnitOfWork.BusinessLayer.Abstract;
using DesignPattern.UnitOfWork.DataAccessLayer.Abstract;
using DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;
        private readonly IUnitofWorkDal _uowDal;

        public GenericService(IGenericDal<T> genericDal, IUnitofWorkDal uowDal)
        {
            _genericDal = genericDal;
            _uowDal = uowDal;
        }

        public void TDelete(int id)
        {
           _genericDal.Delete(id);
            _uowDal.Commit();

        }

        public T TGetById(int id)
        {
           return _genericDal.GetById(id);
        }

        public List<T> TGetList()
        {
            return _genericDal.GetList();
        }

        public void TInsert(T entity)
        {
            _genericDal.Insert(entity);
            _uowDal.Commit();
        }

        public void TMultiUpdate(List<T> entity)
        {
           _genericDal.MultiUpdate(entity);
            _uowDal.Commit();
        }

        public void TUpdate(T entity)
        {
           _genericDal.Update(entity);
            _uowDal.Commit();
        }
    }
}
