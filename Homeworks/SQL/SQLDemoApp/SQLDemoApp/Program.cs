
using DataAccessLibrary;
using Microsoft.Extensions.Configuration;

SqlCrud sql = new SqlCrud(GetConnectionString());


//ReadAllUsersAsync(sql);
ReadAllUsers(sql);

User(sql, 1);

static void ReadAllUsers(SqlCrud sql)
{
    var rows = sql.GetAllUsers();

    foreach (var row in rows)
    {
        Console.WriteLine(row.ToString());
    }
}
static void User(SqlCrud sql,int id)
{
    var output = sql.GetUserById(id);
    Console.WriteLine("Id");
    Console.WriteLine(output.ToString());
}

static async void ReadAllUsersAsync(SqlCrud sql)
{
    var rows = await sql.GetAllUsersAsync();

    foreach (var row in rows)
    {
        Console.WriteLine(row.ToString());
    }
}


static string GetConnectionString(string connectionStringName = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;
}