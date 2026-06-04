using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern
{
    public class CheapShipping : ShippingMethod
    {
        public override IVehicle ShippingFactory()
        {
            return new Car();
        }
    }
}
