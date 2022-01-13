using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    class OrderService : IOrderService<Order>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> Find()
        {
            throw new NotImplementedException();
        }
        public Order FindById(int id)
        {
            string query = $"SELECT * FROM XX Where XX = {id} ";

            throw new NotImplementedException();
        }

        public bool Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
