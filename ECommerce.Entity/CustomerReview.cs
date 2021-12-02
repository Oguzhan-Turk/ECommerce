using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class CustomerReview
    {
        public int ReviewID { get;}
        public Customer _Customer { get; set; }
        public Product _Product { get; set; }
        public string Comment { get; set; }
        public byte Rating { get; set; }
    }
}
