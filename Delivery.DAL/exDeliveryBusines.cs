using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public class exDeliveryBusines:exDelivery
    {
        public int exDeliveryBusinesId { get; set; }
        public exPhoneExt exPhoneRecipient { get; set; }
        public exPhoneExt exPhoneSender { get; set; }
        public exAddressExt RecipientContact { get; set; }
        public string RecipientName { get; set; }
        public exAddressExt SenderContact { get; set; }
        public string SenderName { get; set; }
        public int KindTariffId { get; set; }
        public int WeightActual { get; set; }
        public int WeightVolume { get; set; }

        //public override exPhoneExt GetReceiverPhones()
        //{
        //    return exPhoneRecipient;
        //}
        //public override exPhoneExt GetSenderPhones()
        //{
        //    return exPhoneSender;
        //}
    }
}
