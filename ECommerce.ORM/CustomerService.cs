using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    class CustomerService : ICustomerService<Customer>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Find()
        {
            throw new NotImplementedException();
        }
        public Customer FindById(int id)
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
