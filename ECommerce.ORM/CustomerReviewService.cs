using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    class CustomerReviewService : ICustomerReviewService<CustomerReview>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerReview entity)
        {
            throw new NotImplementedException();
        }

        public List<CustomerReview> Find()
        {
            throw new NotImplementedException();
        }
        public CustomerReview FindById(int id)
        {
            string query = $"SELECT * FROM XX Where XX = {id} ";

            throw new NotImplementedException();
        }

        public bool Update(CustomerReview entity)
        {
            throw new NotImplementedException();
        }
    }
}
