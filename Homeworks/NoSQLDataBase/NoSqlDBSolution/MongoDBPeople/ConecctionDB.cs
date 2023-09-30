using DataAccessPeopleLibrary;
using DataAccessPeopleLibrary.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBPeople
{
    public static class ConecctionDB
    {
        private static MongoDBDataAccessPeople db = new MongoDBDataAccessPeople("PeopleDB", GetConecctionString());
        static string tablename = "People";

        private static string GetConecctionString(string conecctionString = "Default")
        {
            string output = "";
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            output = config.GetConnectionString(conecctionString)!;

            return output;
        } 

        public static void GetAllUsers()
        {
            var people = db.LoadRecords<PeopleModel>(tablename);

            foreach (var company in people)
            {
                if (company is PeopleModel)
                {
                    Console.WriteLine($"{company.Id}: {company.NameCompany} {company.Description}");
                }
            }
        }
        public static void CreateContact(PeopleModel contact)
        {
            db.UpersertRecord(tablename, contact.Id, contact);
        }
        public static void CreateMovie(MoviesModel movie)
        {
            db.UpersertRecord(tablename, movie.Id, movie);
        }
    }
}
