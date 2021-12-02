using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public abstract class User
    {
        public int UserID { get;}
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public Address _Address { get; set; }
        public string EMail { get; set; }
    }
}
