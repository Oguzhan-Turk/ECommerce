using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Seller
    {
        public int SellerID { get; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public Address _Address { get; set; }
        public string EMail { get; set; }
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string HomePage { get; set; }
    }
}
