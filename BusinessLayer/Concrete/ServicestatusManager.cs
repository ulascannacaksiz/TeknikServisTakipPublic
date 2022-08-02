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
    public class ServicestatusManager : IServicestatusService
    {
        IServicestatusDal _ıservicestatusdal;

        public ServicestatusManager(IServicestatusDal ıservicestatusdal)
        {
            _ıservicestatusdal = ıservicestatusdal;
        }

        public List<Servicestatus> GetList()
        {
            return _ıservicestatusdal.GetAll();
        }

        public void TAdd(Servicestatus t)
        {
           _ıservicestatusdal.Insert(t);
        }

        public void TDelete(Servicestatus t)
        {
            throw new NotImplementedException();
        }

        public Servicestatus TGetById(int id)
        {
            return _ıservicestatusdal.GetById(id);
        }

        public void TUpdate(Servicestatus t)
        {
            _ıservicestatusdal.Update(t);
        }
    }
}
