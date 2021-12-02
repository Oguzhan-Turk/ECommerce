using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Seller:User
    {
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string HomePage { get; set; }
    }
}
