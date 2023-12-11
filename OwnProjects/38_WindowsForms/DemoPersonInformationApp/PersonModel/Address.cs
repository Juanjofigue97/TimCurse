using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonModelLibrary
{
    public class Address
    {
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string SecondHouseAddress { get; set; }
        public override string ToString()
        {
            return $"{HomeAddress} , {WorkAddress} , {SecondHouseAddress}";
        }
    }
}
