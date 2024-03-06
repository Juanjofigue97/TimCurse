using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyLibrary
{
    public class DemoDependecy : IDemoDependecy
    {
        public string GiveRandomNumber()
        {
            int randomValue = Random.Shared.Next(1, 100);
            return $"The value is {randomValue}";
        }
    }
}
