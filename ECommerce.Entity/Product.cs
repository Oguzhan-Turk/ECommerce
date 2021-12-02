using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Product
    {
        public int ProductID { get;}
        public Category _Category { get; set; }
        public Seller _Seller { get; set; }
        public string ProductName { get; set; }
        public int UnitStock { get; set; }
        public double UnitPrice { get; set; }
        public CustomerReview _CustomerReview { get; set; }
    }
}
