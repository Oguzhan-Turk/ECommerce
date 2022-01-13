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
        public bool Delete(int id)
        {
            string query = $"DELETE FROM Address WHERE AddressID = {id};";
            return Tools.SqlCommandConnectionWithQuery(query);
        }

        public bool Insert(Address entity)
        {
            string query = $"INSERT INTO Address (Country, City, Street, HouseNumber, ZipCode) VALUES('{entity.Country}', '{entity.City}', '{entity.Street}', {entity.HouseNumber}, '{entity.ZipCode}'); ";
            return Tools.SqlCommandConnectionWithQuery(query);
        }

        public List<Address> Find()
        {
            string query = "SELECT * FROM Address";
            DataTable dataTable = Tools.GetDataTableUseQuery(query);

            //foreach (var item in Tools.ToList<Address>(dataTable))
            //{
            //    Console.WriteLine($"Address ID : {item.AddressID}  Country : {item.Country}  City : {item.City}  Street : {item.Street}  House Number : {item.HouseNumber}  Zip Code : {item.ZipCode}");
            //}
            return Tools.ToList<Address>(dataTable);
        }
        public Address FindById(int id)
        {
            string query = $"SELECT * FROM Address Where AddressID = {id} ";
            DataTable dataTable = Tools.GetDataTableUseQuery(query);
            //Address selectedAddress = Tools.DataTableToEntity<Address>(dataTable);

            return Tools.DataTableToEntity<Address>(dataTable);
        }


        public bool Update(Address entity)
        {
            //Address entity = FindById(id);
            string query = $"UPDATE Address SET [Country] = '{entity.Country}', [City] = '{entity.City}', [Street] = '{entity.Street}', [HouseNumber] = {entity.HouseNumber}, [ZipCode] = '{entity.ZipCode}' WHERE AddressID = {entity.AddressID};";
            return Tools.SqlCommandConnectionWithQuery(query);

        }
    }
}
