using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBUI
{
    public static class Helper
    {
        private static MongoDBDataAccess db = new MongoDBDataAccess("MongoContactsDB", GetConecctionString());
        static string tablename = "Contacts";
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
            db.UpersertRecord(tablename, contact.Id, contact);
        }

        public static void GetAllContacs()
        {
            var contacts = db.LoadRecords<ContactModel>(tablename);

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
            }

        }
        public static void GetContactById(string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordsById<ContactModel>(tablename, guid);

            Console.WriteLine($"{contact.Id}: {contact.FirstName}");
        }
        public static void UpdateContactsFirstName (string firstName, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordsById<ContactModel>(tablename, guid);

            contact.FirstName = firstName;

            db.UpersertRecord(tablename,contact.Id, contact);   

            Console.WriteLine($"{contact.Id}: {contact.FirstName}");
        }

        public static void RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            Guid guid = new Guid(id);
            var contact = db.LoadRecordsById<ContactModel>(tablename, guid);

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            //foreach (var phone in contact.PhoneNumbers)
            //{
            //    if (phone.PhoneNumber == phoneNumber)
            //    {
            //        Console.WriteLine($"{phone.PhoneNumber} Removed");
            //        contact.PhoneNumbers.Remove(phone);
            //        break;
            //    }
            //}

            db.UpersertRecord(tablename, contact.Id, contact);
        }
        public static void RemoveUser(string id)
        {
            Guid guid = new Guid(id);
            db.DeleteRecord<ContactModel>(tablename, guid);
        }

    }
}
