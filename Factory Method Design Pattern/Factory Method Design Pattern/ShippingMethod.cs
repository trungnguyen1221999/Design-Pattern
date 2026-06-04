using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern
{
    public abstract class ShippingMethod
    {
        public abstract IVehicle ShippingFactory();

        public string Deliver ()
        {
            var Vehicle = ShippingFactory();
            return Vehicle.Ship();
        }
    }
}
