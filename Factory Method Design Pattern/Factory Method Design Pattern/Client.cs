using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern
{
    public class Client
    {
        public void Delivery(ShippingMethod shippingMethod)
        {
            Console.WriteLine($"Ship by {shippingMethod.Deliver()}");
        }
    }
}
