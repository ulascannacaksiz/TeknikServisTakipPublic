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
    public class DistirictManager : IDistrictService
    {
        IDistrictDal _distirictDal;

        public DistirictManager(IDistrictDal distirictDal)
        {
            _distirictDal = distirictDal;
        }

        public List<District> GetCityDistricts(int id)
        {
            return _distirictDal.GetListAll(x => x.CityId == id);
        }

        public List<District> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(District t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(District t)
        {
            throw new NotImplementedException();
        }

        public District TGetById(int id)
        {
            return _distirictDal.GetById(id);
        }

        public void TUpdate(District t)
        {
            throw new NotImplementedException();
        }
    }
}
