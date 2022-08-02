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
    public class EfUserProductRepository : GenericRepository<UserProduct>, IUserProductDal
    {
        public List<UserProduct> GetProductList(int id)
        {

            using (var c = new Context())
            {
                return c.UserProducts.Include(x => x.Serviceproduct).ThenInclude(x=>x.Servicestatus).Where(c=>c.UserId==id).ToList();
            }
        }

    }
}
