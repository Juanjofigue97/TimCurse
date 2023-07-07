using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    internal class Boat : Vehicle
    {
        public Boat(string name) : base(name)
        {
        }

        public double Lenght { get; set; }
    }
}
