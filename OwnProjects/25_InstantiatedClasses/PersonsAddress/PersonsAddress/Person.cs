using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAddress
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int IdentityCard { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
