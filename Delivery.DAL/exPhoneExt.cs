using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public class exPhoneExt
    {
        public int exPhoneExtId { get; set; }
        public int AddNUmber { get; set; }
        public int exDeliveryId { get; set; }
        public int exPhoneId { get; set; }
        public int PhoneCode { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneTypeId { get; set; }
        public string CountryCode { get; set; }

        public exPhoneExt GetFullPhone()
        {
            exPhoneExt exPhoneExt = new exPhoneExt();
            exPhoneExt.AddNUmber = AddNUmber;
            exPhoneExt.exDeliveryId = exDeliveryId;
            exPhoneExt.exPhoneId = exPhoneId;
            exPhoneExt.PhoneCode = PhoneCode;
            exPhoneExt.PhoneNumber = PhoneNumber;
            exPhoneExt.PhoneTypeId = PhoneTypeId;
            exPhoneExt.CountryCode = CountryCode;
            return exPhoneExt;
        }
        public override string ToString()
        {
            return string.Format($"AddNUmber: {AddNUmber}\n" +
                $"exDeliveryId: {exDeliveryId}\n" +
                $"exPhoneId: {exPhoneId}\n" +
                $"PhoneCode: {PhoneCode}\n" +
                $"PhoneNumber: {PhoneNumber}\n" +
                $"PhoneTypeId: {PhoneTypeId}\n" +
                $"CountryCode: {CountryCode}");
        }
    }
}
