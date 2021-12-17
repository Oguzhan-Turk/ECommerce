using ECommerce.Common;
using ECommerce.Entity;
using ECommerce.Service.api;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public class AddressService : IAddressService<Address>
    {
        public bool Delete(Address entity)
        {
            string query = " asd asd ";
           return Tools.SqlCommandConnectionWithQuery(query);   
        }

        public bool Insert(Address entity)
        {
            throw new NotImplementedException();
        }

        public List<Address> Select()
        {
            string query = "Select * From TB_Address";
            DataTable dataTable = Tools.GetDataTableUseQuery(query);
            return Tools.ToList<Address>(dataTable);
        }

        public bool Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
