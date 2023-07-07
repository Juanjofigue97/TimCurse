using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClasses
{
    public abstract class Vehicle
    {
        public Vehicle(string name)
        { 
            Name = name;
        }
        public string? OperatingLocation { get; set; }
        public string? Name { get; set; }
        public string? TravelSpeed { get; set; }
        public int PassengerCapacity { get; set; }
        public double Price { get; set; }
        public string? Model { get; set; }
        public int Fuel { get; set; }

        public void StartVehicule() 
        {
            Console.WriteLine($"The { Name } start");
        }



    }
}
