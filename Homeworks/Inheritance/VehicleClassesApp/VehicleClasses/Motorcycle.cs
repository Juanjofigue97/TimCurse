using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string name) : base(name)
        {
        }

        public int NumberOfWheels { get; set; }
        public int Horsepower { get; set; }
    }
}
