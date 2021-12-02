using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Category
    {
         public int CategoryID { get;}
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Product> _Products { get; set; } 
    }
}
