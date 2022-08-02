using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _ıcustomerDal;

        public CustomerManager(ICustomerDal ıcustomerDal)
        {
            _ıcustomerDal = ıcustomerDal;
        }

        public List<Customer> GetList()
        {
            return _ıcustomerDal.GetAll();
        }

        public void TAdd(Customer t)
        {
            _ıcustomerDal.Insert(t);
        }

        public void TDelete(Customer t)
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            return _ıcustomerDal.GetById(id);
        }

        public void TUpdate(Customer t)
        {
            _ıcustomerDal.Update(t);
        }
    }
}
