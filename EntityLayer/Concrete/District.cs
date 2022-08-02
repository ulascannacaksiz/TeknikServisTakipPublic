using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string ProvinceName { get; set; }
        public bool Status { get; set; }
    }

}
