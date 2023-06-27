using PersonsAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAddress
{
    public class ProcessPerson
    {
        public static void PrintAllAddresses(Person person)
        {
            foreach (var address in person.Addresses)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Address");
                Console.WriteLine($"Type: {address.Type}");
                Console.WriteLine($"Street: {address.Street}");
                Console.WriteLine($"City: {address.City}");
                Console.WriteLine($"Statte: {address.State}");
                Console.WriteLine($"Country: {address.Country}");
                Console.WriteLine($"PostalCode: {address.PostalCode}");
            };
        }

        public static void SetPostalCode(Person person)
        {
            foreach (var address in person.Addresses.Where(address => address.Country == "Colombia"))
            {
                address.PostalCode = "578986";
            }
        }

        public static List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Juan",
                    LastName = "Figueroa",
                    Email = "juan.figue@gmail.com",
                    Age = 30,
                    IdentityCard = 1234445,
                    Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            Type = AddressType.Home,
                            Street = "9",
                            City = "Pasto",
                            Country = "Colombia",
                            State = "Nariño"
                        },
                        new Address()
                        {
                            Type = AddressType.CountrySide,
                            Street = "10",
                            City = "Sandona",
                            Country = "Colombia",
                            State = "Nariño"
                        },
                        new Address()
                        {
                            Type = AddressType.CountrySide,
                            Street = "10",
                            City = "Lima",
                            Country = "Peru",
                            State = "Lima"
                        },
                    }
                },
                new Person()
                {
                    FirstName = "Marcela",
                    LastName = "Arevalo",
                    Email = "juan.figue@gmail.com",
                    Age = 30,
                    IdentityCard = 1234445,
                    Addresses = new List<Address>()
                    {
                        new Address()
                        {
                            Type = AddressType.Home,
                            Street = "20",
                            City = "Pereira",
                            Country = "Colombia",
                            State = "Risaralda"
                        },
                        new Address()
                        {
                            Type = AddressType.CountrySide,
                            Street = "10",
                            City = "Sandona",
                            Country = "Colombia",
                            State = "Nariño"
                        },
                        new Address()
                        {
                            Type = AddressType.CountrySide,
                            Street = "10",
                            City = "Lima",
                            Country = "Peru",
                            State = "Lima"
                        },
                    }
                }
            };
        }
    }
}
