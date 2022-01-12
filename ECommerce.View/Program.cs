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
            List<Address> addressList = addressService.Select();
            addressService.Select();

            //Address addressKo = new Address();
            //addressKo.Country = "Turkey";
            //addressKo.City = "Kocaeli";
            //addressKo.Street = "Sultan";
            //addressKo.HouseNumber = 12;
            //addressKo.ZipCode = "41400";

            //addressService.Insert(addressKo);

            //addressService.Delete(3);


            foreach (var item in addressList)
            {
                Console.WriteLine($"Address ID : {item.AddressID}  Country : {item.Country}  City : {item.City}  Street : {item.Street}  House Number : {item.HouseNumber}  Zip Code : {item.ZipCode}");
            }



        }
    }
}
