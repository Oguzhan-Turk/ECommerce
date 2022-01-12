using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entity;
using ECommerce.Service.api;

namespace ECommerce.Service
{
    class ProductService : IProductService<Product>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find()
        {
            throw new NotImplementedException();
        }
        public Product FindById(int id)
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
