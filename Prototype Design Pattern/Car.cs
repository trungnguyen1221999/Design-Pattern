using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Design_Pattern
{
    public class Car : ICloneable
    {
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        private DateTime _createdDate { get; set;  } = DateTime.Now;
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string GetDetail ()
        {
            return $"Car's Name : {this.Name} - Car's Model : {this.Model}  - Car's Color: {this.Color} - Manufacture Date: {this._createdDate}";

        }
    }
}
