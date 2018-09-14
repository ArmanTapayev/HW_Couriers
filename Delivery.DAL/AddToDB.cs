using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Delivery.DAL
{
    public class AddToDB
    {
        public static void CreatePhone(exPhoneExt request)
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                var phones = db.GetCollection<exPhoneExt>("Phones");
                phones.Insert(request);
            }
        }
        public static void CreateAddress(exAddressExt request)
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                var addresses = db.GetCollection<exAddressExt>("Addresses");
                addresses.Insert(request);
            }
        }
        public  static void CreateExDeliveryBlitz(ExDeliveryBlitz request)
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                var deliveries = db.GetCollection<ExDeliveryBlitz>("ExDeliveryBlitz");
                deliveries.Insert(request);
            }
        }
        public static void CreateExDeliveryBusiness(exDeliveryBusines request)
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                var deliveries = db.GetCollection<exDeliveryBusines>("exDeliveryBusines");
                deliveries.Insert(request);
            }
        }
        public static void CreateExDeliveryExt(exDelivery request)
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                var deliveries = db.GetCollection<exDelivery>("exDeliveryExt");
                deliveries.Insert(request);
            }
        }
        public static IEnumerable<exPhoneExt> ReturnAllPhones()
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                return db.GetCollection<exPhoneExt>("Phones").FindAll();
            }
        }
        public static IEnumerable<exAddressExt> ReturnAllAddresses()
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                return db.GetCollection<exAddressExt>("Addresses").FindAll();
            }
        }
        public static IEnumerable<ExDeliveryBlitz> ReturnAllExDeliveryBlitz()
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                return db.GetCollection<ExDeliveryBlitz>("ExDeliveryBlitz").FindAll();
            }
        }
        public static IEnumerable<exDeliveryBusines> ReturnAllExDeliveryBusinesz()
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                return db.GetCollection<exDeliveryBusines>("exDeliveryBusines").FindAll();
            }
        }
        public static IEnumerable<exDelivery> ReturnAllExDeliveryExt()
        {
            using (var db = new LiteDatabase(@"DeliveryDB.db"))
            {
                return db.GetCollection<exDelivery>("exDeliveryExt").FindAll();
            }
        }
    }

}
