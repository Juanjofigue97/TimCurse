using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();
        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<User> GetAllUsers()
        {
            string sql = "SELECT Id,Login,email,password FROM dbo.Users;";

            return db.LoadData<User, dynamic>(sql, new { }, _connectionString);
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            string sql = "SELECT Id,Login,email,password FROM dbo.Users;";

            return await db.LoadDataAsync<User, dynamic>(sql, new { }, _connectionString);
        }

        public User GetUserById(int id)
        {
            string sql = "SELECT Id,Login,email,password FROM dbo.Users where Id = @id;";

            return db.FirstValue<User, dynamic>(sql, new { id = id }, _connectionString);
        }

    }
}
