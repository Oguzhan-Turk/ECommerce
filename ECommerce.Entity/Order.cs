using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Order
    {
        public int OrderID { get; }
        public DateTime OrderTime { get; set; }
        public Basket BasketDetails { get; set; }

    }
}
