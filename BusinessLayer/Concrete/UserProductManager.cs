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
    public class UserProductManager : IUserProductService
    {
        IUserProductDal _userProductDal;

        public UserProductManager(IUserProductDal userProductDal)
        {
            _userProductDal = userProductDal;
        }

        public List<UserProduct> GetList()
        {
            return _userProductDal.GetAll();
        }

        public List<UserProduct> GetMyProductList(int id)
        {
            return _userProductDal.GetProductList(id);
        }

        public void TAdd(UserProduct t)
        {
            _userProductDal.Insert(t);
        }

        public void TDelete(UserProduct t)
        {
            throw new NotImplementedException();
        }

        public UserProduct TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserProduct t)
        {
            throw new NotImplementedException();
        }
    }
}
