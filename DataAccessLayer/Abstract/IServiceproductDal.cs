using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IServiceproductDal:IGenericDal<Serviceproduct>
    {

        List<Serviceproduct> GetProductsWithCustomer();
        List<Serviceproduct> GetProdoctDetailById(int id);
         
    }
}
