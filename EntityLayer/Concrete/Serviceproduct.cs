using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Serviceproduct
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Problem { get; set; }
        public string Notes { get; set; }
        public int Price { get; set; }
        public int ServicestatusId { get; set; }
        public Servicestatus Servicestatus { get; set; }
        public DateTime LastModifedDate { get; set; }// Son işlem tarihi
        public DateTime CreateDate { get; set; }
        public string UniqeId { get; set; }
    }
}
