using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern
{
    public class HeavyProductShipping : ShippingMethod
    {
        public override IVehicle ShippingFactory()
        {
            return new Ship();
        }
    }
}
