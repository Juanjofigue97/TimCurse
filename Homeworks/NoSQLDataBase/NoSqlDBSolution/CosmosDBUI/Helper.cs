using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDBUI
{
    public static class Helper
    {
        public static string GetConecctionString(string conecctionString = "Default")
        {
            string output = "";
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(conecctionString)!;

            return output;
        }
        public static void CreateContact(ContactModel contact)
        {
        }

        public static void GetAllContacs()
        {


        }
        public static void GetContactById(string id)
        {

        }
        public static void UpdateContactsFirstName (string firstName, string id)
        {

        }

        public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {

        }
        public static void RemoveUser(string id)
        {

        }

    }
}
