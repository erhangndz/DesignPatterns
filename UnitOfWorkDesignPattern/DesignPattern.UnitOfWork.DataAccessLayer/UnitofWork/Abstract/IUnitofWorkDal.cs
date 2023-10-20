using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Abstract
{
    public interface IUnitofWorkDal
    {
        void Commit();
    }
}
