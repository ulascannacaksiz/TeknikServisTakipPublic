using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserProduct
    {
        public int Id { get; set; }
        public int ServiceproductId { get; set; }
        public Serviceproduct Serviceproduct { get; set; }
        public int UserId { get; set; }

    }
}
