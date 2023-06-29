

using DemoLibrary.Models.UserModel;

Console.WriteLine("We are work with ClassLibrary");

var person = new User()
{
    FirstName = "Juan",
    LastName = "Figueroa"
};

Console.WriteLine($"Hello {person.FirstName} {person.LastName}! ");

var address = new Addresses();