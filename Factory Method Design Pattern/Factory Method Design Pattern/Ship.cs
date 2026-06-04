using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Design_Pattern
{
    public class Ship : IVehicle
    {
        string IVehicle.Ship()
        {
            return "ship";
        }
    }
}
