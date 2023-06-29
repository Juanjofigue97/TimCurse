using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    public class Addresses
    {
        public Addresses(string city, string address)
        {
            City = city;
            Address = address;
        }

        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        private int _numberHouse;

        public int NumberHouse
        {
            get { return _numberHouse; }
            set { _numberHouse = value; }
        }


        public string FullAddress
        {
            get { 
                return $"{Address} - {City} || Postal Code: {PostalCode}"; 
            }
        }

    }
}
