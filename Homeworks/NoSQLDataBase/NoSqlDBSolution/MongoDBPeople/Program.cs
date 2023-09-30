
using DataAccessPeopleLibrary.Models;
using MongoDB.Driver;
using MongoDBPeople;


//var people = DataPeople.GetData();

//foreach (var company in people)
//{
//    ConecctionDB.CreateContact(company);
//}

var movie = new MoviesModel()
{
    Author = "Mike Nichols",
    Description = "Description",
    NameMovie = "The Graduate",
    Year = "2023"
};
ConecctionDB.CreateMovie(movie);

ConecctionDB.GetAllUsers();
Console.WriteLine("Done Processing MongoDB");


Console.ReadLine();