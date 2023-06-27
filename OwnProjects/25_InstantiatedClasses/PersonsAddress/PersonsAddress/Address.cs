using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAddress
{
    public class Address
    {
        public AddressType Type { get; set; } 
        public string Street { get; set; } 
        public string City { get; set; } 
        public string State { get; set; } 
        public string Country { get; set; } 
        public string PostalCode { get; set; }
    }

    public enum AddressType
    {
        Home,
        Work,
        Second,
        CountrySide
    }
}
