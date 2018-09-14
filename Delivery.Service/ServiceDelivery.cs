using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.DAL;
using LiteDB;

namespace Delivery.Service
{
    public class ServiceDelivery
    {
        ConsoleColor color = Console.ForegroundColor;
        public void AddPhone(exPhoneExt exPhoneExt)
        {
            AddToDB.CreatePhone(exPhoneExt);
        }
        public void AddAddress(exAddressExt exAddressExt)
        {
            AddToDB.CreateAddress(exAddressExt);
        }
        public void AddExDeliveryBusines(exDeliveryBusines exDeliveryBusines)
        {
            AddToDB.CreateExDeliveryBusiness(exDeliveryBusines);
        }
        public void AddExDeliveryBlitz(ExDeliveryBlitz exDeliveryBlitz)
        {
            AddToDB.CreateExDeliveryBlitz(exDeliveryBlitz);
        }
        public void AddExDeliveryExt(exDeliveryExt exDeliveryExt)
        {
            AddToDB.CreateExDeliveryExt(exDeliveryExt);
        }
        public exPhoneExt CreatePhone()
        {
            exPhoneExt exPhoneExt = new exPhoneExt();
            Console.WriteLine("Введите AddNUmber");
            exPhoneExt.AddNUmber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите exDeliveryId");
            exPhoneExt.exDeliveryId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите exPhoneId");
            exPhoneExt.exPhoneId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите PhoneCode");
            exPhoneExt.PhoneCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите PhoneNumber");
            exPhoneExt.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите PhoneTypeId");
            exPhoneExt.PhoneTypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите CountryCode");
            exPhoneExt.CountryCode = Console.ReadLine();
            return exPhoneExt;
        }
        public void ShowPhones(exPhoneExt exPhoneExt)
        {          
            Console.WriteLine($"AddNUmber: {exPhoneExt.AddNUmber}\n" +
                $"exDeliveryId: {exPhoneExt.exDeliveryId}\n" +
                $"exPhoneId: {exPhoneExt.exPhoneId}\n" +
                $"PhoneCode: {exPhoneExt.PhoneCode}\n" +
                $"PhoneNumber: {exPhoneExt.PhoneNumber}\n" +
                $"PhoneTypeId: {exPhoneExt.PhoneTypeId}\n" +
                $"CountryCode: {exPhoneExt.CountryCode}");

            Console.WriteLine(new string('-', 50));
        }

        public exAddressExt CreateAddress()
        {
            exAddressExt exAddressExt = new exAddressExt();
            Console.WriteLine("Введите exAddressExt");
            exAddressExt.ApartmentOffice = Console.ReadLine();
            Console.WriteLine("Введите City");
            exAddressExt.City = Console.ReadLine();
            Console.WriteLine("Введите CityId");
            exAddressExt.CityId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите CityName");
            exAddressExt.CityName = Console.ReadLine();
            Console.WriteLine("Введите CountryName");
            exAddressExt.CountryName = Console.ReadLine();
            Console.WriteLine("Введите Country");
            exAddressExt.Country = Console.ReadLine();
            Console.WriteLine("Введите House");
            exAddressExt.House = Console.ReadLine();
            Console.WriteLine("Введите Housing");
            exAddressExt.Housing = Console.ReadLine();
            Console.WriteLine("Введите PostCode");
            exAddressExt.PostCode = Console.ReadLine();
            Console.WriteLine("Введите Street");
            exAddressExt.Street = Console.ReadLine();
            return exAddressExt;
        }
        public void ShowAddress(exAddressExt exAddressExt)
        {
            Console.WriteLine($"exAddressExtId: {exAddressExt.exAddressExtId}\n" +
                $"ApartmentOffice: {exAddressExt.ApartmentOffice}\n" +
                $"City: {exAddressExt.City}\n" +
                $"CityId: {exAddressExt.CityId}\n" +
                $"CityName: {exAddressExt.CityName}\n" +
                $"CountryName: {exAddressExt.CountryName}\n" +
                $"Country: {exAddressExt.Country}\n" +
                $"House: {exAddressExt.House}\n" +
                $"Housing: {exAddressExt.Housing}\n" +
                $"PostCode: {exAddressExt.PostCode}\n" +
                $"Street: {exAddressExt.Street}");

            Console.WriteLine(new string('-', 50));
        }
        public exDelivery CreateDelivery()
        {
            exDelivery exDeliveryBusines = new exDelivery();
            ServiceDelivery serviceDelivery = new ServiceDelivery();
            exPhoneExt exPhoneExt = new exPhoneExt();
            exAddressExt exAddressExt = new exAddressExt();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите RecipientName: ");
            Console.ForegroundColor = color;
            exDeliveryBusines.RecipientName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите SenderName: ");
            Console.ForegroundColor = color;
            exDeliveryBusines.SenderName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите exPhoneRecipient по Id: ");
            Console.ForegroundColor = color;

            foreach (var item in AddToDB.ReturnAllPhones())
            {
                serviceDelivery.ShowPhones(item);
            }
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (exPhoneExt item in AddToDB.ReturnAllPhones())
            {
                if (item.exPhoneExtId==id)
                {
                    exPhoneExt = item;
                    break;
                }
            }
            exDeliveryBusines.exPhoneRecipient = exPhoneExt;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите exPhoneSender по Id: ");
            Console.ForegroundColor = color;

            foreach (var item in AddToDB.ReturnAllPhones())
            {
                serviceDelivery.ShowPhones(item);
            }
            id = Convert.ToInt32(Console.ReadLine());
            foreach (exPhoneExt item in AddToDB.ReturnAllPhones())
            {
                if (item.exPhoneExtId == id)
                {
                    exPhoneExt = item;
                    break;
                }
            }
            exDeliveryBusines.exPhoneRecipient = exPhoneExt;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите RecipientContact по Id: ");
            Console.ForegroundColor = color;

            foreach (var item in AddToDB.ReturnAllAddresses())
            {
                serviceDelivery.ShowAddress(item);
            }
            id = Convert.ToInt32(Console.ReadLine());
            foreach (exAddressExt item in AddToDB.ReturnAllAddresses())
            {
                if (item.exAddressExtId == id)
                {
                    exAddressExt = item;
                    break;
                }
            }
            exDeliveryBusines.RecipientContact = exAddressExt;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите SenderContact по Id: ");
            Console.ForegroundColor = color;

            foreach (var item in AddToDB.ReturnAllAddresses())
            {
                serviceDelivery.ShowAddress(item);
            }
            id = Convert.ToInt32(Console.ReadLine());
            foreach (exAddressExt item in AddToDB.ReturnAllAddresses())
            {
                if (item.exAddressExtId == id)
                {
                    exAddressExt = item;
                    break;
                }
            }
            exDeliveryBusines.SenderContact = exAddressExt;

            //Console.WriteLine("Введите KindTariffId: ");
            //exDeliveryBusines.KindTariffId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите WeightActual: ");
            //exDeliveryBusines.WeightActual = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите WeightVolume: ");
            //exDeliveryBusines.WeightVolume = Convert.ToInt32(Console.ReadLine());

            return exDeliveryBusines;
        }

        //public void ShowDelivery(exDelivery delivery)
        //{
        //    Console.WriteLine( // $"exDeliveryId: {delivery.exDeliveryId}\n" +
        //        $"exPhoneRecipient: {delivery.exPhoneRecipient.ToString()}\n" +
        //        $"exPhoneSender: {delivery.ExPhoneSender.ToString()}\n" +
        //        $"RecipientContact: {delivery.RecipientContact.ToString()}\n" +
        //        $"RecipientName: {delivery.RecipientName}\n" +
        //        $"SenderContact: {delivery.SenderContact.ToString()}\n" +
        //        $"SenderName: {delivery.SenderName.ToString()}");

        //    Console.WriteLine(new string('-', 50));
        //}
    }
}
