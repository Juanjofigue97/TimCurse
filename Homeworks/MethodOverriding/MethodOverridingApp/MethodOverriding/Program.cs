

using MethodOverriding;

Console.WriteLine("In this program, we are going to override the ToString() method that exists in all C# objects.");
Console.WriteLine("This program was made by Juan Jose Figueroa.");
Console.WriteLine("---------------------------------------------");
Console.WriteLine();

PersonModel person = new()
{
    Name = "Juan",
    LastName = "Figueroa",
    Age = 26,
};

Console.WriteLine("We are going to override the ToString() method. ");

Console.WriteLine(person.ToString());




Console.ReadLine();