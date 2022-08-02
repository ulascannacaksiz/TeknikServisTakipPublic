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
    public class ServiceproductManager : IServiceproductService
    {
        IServiceproductDal _serviceproductDal;

        public ServiceproductManager(IServiceproductDal serviceproductDal)
        {
            _serviceproductDal = serviceproductDal;
        }

        public List<Serviceproduct> GetList()
        {
            return _serviceproductDal.GetProductsWithCustomer();
        }

        public List<Serviceproduct> GetProductDetailById(int id)
        {
            return _serviceproductDal.GetProdoctDetailById(id);
        }


        public void TAdd(Serviceproduct t)
        {
            _serviceproductDal.Insert(t);
        }

        public void TDelete(Serviceproduct t)
        {
            throw new NotImplementedException();
        }

        public Serviceproduct TGetById(int id)
        {
            return _serviceproductDal.GetById(id);
        }

        public void TUpdate(Serviceproduct t)
        {
            _serviceproductDal.Update(t);
        }
    }
}
