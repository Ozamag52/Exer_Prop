using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_Prop.Entities.Enums
{
    enum OrderStatus : int 
    {
        PendindPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3 
    }
}
