﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public interface IexDelivery
    {
        exPhoneExt GetReceiverPhones();
        exPhoneExt GetSenderPhones();
    }
}
