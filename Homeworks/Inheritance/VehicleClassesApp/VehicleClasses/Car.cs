﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    public class Car : Vehicle
    {
        public Car(string name) : base(name)
        {
        }

        public int NumberOfDoors { get; set; }
    }
}
