using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Customer
    {
        public int CustomerID { get;}
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public Address _Address { get; set; }
        public string EMail { get; set; }
        public int TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Gender _Gender { get; set; }
        public Basket _Basket { get; set; }
    }
}
