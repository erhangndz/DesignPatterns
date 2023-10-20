using DesignPattern.UnitOfWork.DataAccessLayer.Concrete;
using DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.UnitOfWork.DataAccessLayer.UnitofWork.Concrete
{
    public class UnitofWorkDal : IUnitofWorkDal
    {
        private readonly UOWContext _context;

        public UnitofWorkDal(UOWContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
