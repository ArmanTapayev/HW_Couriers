using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public class ExDeliveryBlitz: exDelivery //,IexDelivery
    {      
        public int ContentId { get; set; }
        public string SchemeDelivery { get; set; }

        //public override exPhoneExt GetReceiverPhones()
        //{
        //    return exPhoneRecipienta;
        //}

        //public override exPhoneExt GetSenderPhones()
        //{
        //    return exPhoneSendera;
        //}
    }
}
