using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public class exDelivery
    {
        public int exDeliveryId { get; set; }
        public exPhoneExt exPhoneRecipient { get; set; }
        public exPhoneExt ExPhoneSender { get; set; }
        public exAddressExt RecipientContact { get; set; }
        public string RecipientName { get; set; }
        public exAddressExt SenderContact { get; set; }
        public string SenderName { get; set; }

        //public  exPhoneExt GetReceiverPhones();
        //public abstract exPhoneExt GetSenderPhones();

    }
}
