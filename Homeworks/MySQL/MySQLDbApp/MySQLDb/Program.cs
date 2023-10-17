
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;


MySqlCrud sql = new MySqlCrud(GetConnectionString());


//ReadAllContacts(sql);

PersonModel person = new()
{
    FirstName = "Camilo",
    LastName = "Rodriguez"
};

CreatePerson(sql, person);


static void CreatePerson(MySqlCrud sql, PersonModel person)
{
    try
    {
        sql.SavePerson(person);
        Console.WriteLine("Person save");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
static void ReadAllContacts(MySqlCrud sql)
{
    var rows = sql.GetAllContacts();

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}: {row.FirstName} {row.LastName}");
    }
}

Console.ReadLine();
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