using DataAccessLibrary.Models;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MySqlCrud
    {
        private readonly string _connectionString;
        private MySqlDataAccess db = new MySqlDataAccess();

        public MySqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<PersonModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from People";

            return db.LoadData<PersonModel, dynamic>(sql, new { }, _connectionString);
        }

        public void SavePerson(PersonModel person)
        {
            string sql = "insert into People (firstname,lastname) VALUES (@firstname,@lastname)";
            
            
            db.SaveData(sql, new
            {
                person.FirstName,person.LastName,
            },_connectionString);
        }
    }
}
