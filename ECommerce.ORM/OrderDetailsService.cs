using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    class OrderDetailsService : IOrderDetailsService<OrderDetails>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(OrderDetails entity)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetails> Find()
        {
            throw new NotImplementedException();
        }
        public OrderDetails FindById(int id)
        {
            string query = $"SELECT * FROM XX Where XX = {id} ";

            throw new NotImplementedException();
        }

        public bool Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
