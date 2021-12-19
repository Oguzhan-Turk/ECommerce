using ECommerce.Entity;
using ECommerce.Service;
using System;
using System.Collections.Generic;

namespace ECommerce.View
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressService addressService = new AddressService();
            addressService.Select();
            List<Address> addressList = addressService.Select();
            //Address address = new Address();

            foreach (var item in addressList)
            {
                Console.WriteLine($"Address ID : {item.AddressID}  Country : {item.Country}  City : {item.City}  Street : {item.Street}  House Number : {item.HouseNumber}  Zip Code : {item.ZipCode}");
            }

        }
    }
}
