using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Basket
    {
        public int BasketID { get;}
        public Customer _Customer { get; set; }
        public List<Product> _Products { get; set; }
        public double TotalPrice
        {
            get
            {
                double totalPrice = 0;
                foreach (var item in this._Products)
                {
                    totalPrice += item.UnitPrice;
                }
                return totalPrice;
            }
        }


    }
}
