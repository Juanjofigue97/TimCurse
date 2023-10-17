using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;

namespace AuthorizationFormDemo.DataAccess
{
    public class SQLiteDataAccess
    {
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public async Task<List<T>> LoadDataAsync<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = (await connection.QueryAsync<T>(sqlStatement, parameters)).ToList();
                return rows;
            }
        }

        public T FirstValue<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                T rows = connection.QueryFirst<T>(sqlStatement, parameters);
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
        {
            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
