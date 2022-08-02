using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfServiceproductRepository : GenericRepository<Serviceproduct>, IServiceproductDal
    {

        public List<Serviceproduct> GetProductsWithCustomer()
        {
            using(var c = new Context())
            {
                return c.Serviceproducts.Include(x=>x.Customer).Include(y=>y.Servicestatus).ToList();
            }
        }

        List<Serviceproduct> IServiceproductDal.GetProdoctDetailById(int id)
        {
            using (var c = new Context())
            {
                return c.Serviceproducts.Include(x => x.Customer).Include(y => y.Servicestatus).Where(c => c.Id == id).ToList();
            }
        }
    }
}
