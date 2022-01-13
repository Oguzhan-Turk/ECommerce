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
            List<Address> addressList = addressService.Find();
            addressService.Find();

            //Address addressKo = new Address();
            //addressKo.Country = "Turkey";
            //addressKo.City = "Ankara";
            //addressKo.Street = "Merasim";
            //addressKo.HouseNumber = 30;
            //addressKo.ZipCode = "06600";

            //addressService.Insert(addressKo);

            //addressService.Delete(3);

            //Address t = addressService.FindById(2);
            //Console.WriteLine(t.AddressID);
            //Console.WriteLine(t.Country);
            //Console.WriteLine(t.City);
            //Console.WriteLine(t.Street);
            //Console.WriteLine(t.HouseNumber);
            //Console.WriteLine(t.ZipCode);

            //t.City = "Kocaeli";
            //t.Street = "Bagdat";
            //t.HouseNumber = 12;

            //Console.WriteLine();
            //Console.WriteLine();

            //addressService.Update(t);

            //Console.WriteLine(t.AddressID);
            //Console.WriteLine(t.Country);
            //Console.WriteLine(t.City);
            //Console.WriteLine(t.Street);
            //Console.WriteLine(t.HouseNumber);
            //Console.WriteLine(t.ZipCode);



            //foreach (var item in addressList)
            //{
            //    Console.WriteLine($"Address ID : {item.AddressID}  Country : {item.Country}  City : {item.City}  Street : {item.Street}  House Number : {item.HouseNumber}  Zip Code : {item.ZipCode}");
            //}



        }
    }
}
