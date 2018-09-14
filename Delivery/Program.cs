using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.DAL;
using Delivery.Service;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            bool inProgress = true;
            while (inProgress)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("\t\tКУРЬЕРСКАЯ НАКЛАДНАЯ");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("\t\tВыберите пункт меню:");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("1. Создать КН");
                Console.WriteLine("2. Получить список всех КН");
                Console.WriteLine("3. Получить информацию о всех КН");
                Console.WriteLine("4. Выход");
                Console.ForegroundColor = color;

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("\t1. Создать КН");
                            Console.WriteLine(new string('-', 50));

                            //exPhoneExt phoneExt = new exPhoneExt();
                            //ServiceDelivery serviceDelivery = new ServiceDelivery();
                            //phoneExt = serviceDelivery.CreatePhone();
                            //AddToDB.CreatePhone(phoneExt);
                            //foreach (var item in AddToDB.ReturnAllPhones())
                            //{
                            //    serviceDelivery.ShowPhones(item);
                            //}
                            //exAddressExt exAddressExt = new exAddressExt();
                            //ServiceDelivery serviceDelivery = new ServiceDelivery();
                            //exAddressExt = serviceDelivery.CreateAddress();
                            //AddToDB.CreateAddress(exAddressExt);
                            //foreach (var item in AddToDB.ReturnAllAddresses())
                            //{
                            //    serviceDelivery.ShowAddress(item);
                            //}

                            exDelivery exDeliveryBusines = new exDelivery();
                            ServiceDelivery serviceDelivery = new ServiceDelivery();
                            exDeliveryBusines = serviceDelivery.CreateDelivery();
                            AddToDB.CreateExDeliveryExt(exDeliveryBusines);
                            foreach (exDelivery item in AddToDB.ReturnAllExDeliveryExt())
                            {
                                //serviceDelivery.ShowDelivery(item);
                                Console.WriteLine($"Id: {item.exDeliveryId}\n" +
                                    $"RecipientName: {item.RecipientName}\n" +
                                    $"SenderName: {item.SenderName}\n" +
                                    $"RecipientContact: {item.RecipientContact}\n" +
                                    $"SenderContact: {item.SenderContact}");
                                
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("\t2. Получить список всех КН");
                            Console.WriteLine(new string('-', 50));

                            exDelivery exDeliveryBusines = new exDelivery();
                            ServiceDelivery serviceDelivery = new ServiceDelivery();
                            //exDeliveryBusines = serviceDelivery.CreateDelivery();
                            //AddToDB.CreateExDeliveryExt(exDeliveryBusines);
                            foreach (exDelivery item in AddToDB.ReturnAllExDeliveryExt())
                            {
                                Console.WriteLine(new string('-', 50));
                                //serviceDelivery.ShowDelivery(item);
                                Console.WriteLine($"Id Курьерских Накладных: {item.exDeliveryId}");
                                Console.WriteLine(new string('-', 50));
                            }


                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("\t3. Получить информацию о всех КН");
                            Console.WriteLine(new string('-', 50));

                            exDelivery exDeliveryBusines = new exDelivery();
                            ServiceDelivery serviceDelivery = new ServiceDelivery();
                            //exDeliveryBusines = serviceDelivery.CreateDelivery();
                            //AddToDB.CreateExDeliveryExt(exDeliveryBusines);
                            foreach (exDelivery item in AddToDB.ReturnAllExDeliveryExt())
                            {
                                Console.WriteLine(new string('-', 50));
                                //serviceDelivery.ShowDelivery(item);
                                Console.WriteLine($"Id: {item.exDeliveryId}\n" +
                                    $"RecipientName: {item.RecipientName}\n" +
                                    $"SenderName: {item.SenderName}\n" +
                                    $"RecipientContact: {item.RecipientContact}\n" +
                                    $"SenderContact: {item.SenderContact}");
                                Console.WriteLine(new string('-', 50));
                            }

                        }
                        break;
                    case 4:
                        {

                            Console.WriteLine(new string('-', 50));
                            Console.WriteLine("\t\t4. Выход");
                            Console.WriteLine(new string('-', 50));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Спасибо!");
                            Console.ForegroundColor = color;
                            inProgress = false;
                            Console.WriteLine(new string('-', 50));
                        }
                        break;


                    default:
                        {
                            Console.WriteLine("Выберите пункт меню");
                        }
                        break;
                }
            }
        }
    }
}
