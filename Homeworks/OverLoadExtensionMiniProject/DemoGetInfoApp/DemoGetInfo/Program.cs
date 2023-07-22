

using DemoGetInfo;

Console.WriteLine("In this program, we will create method extensions and use overloading ");
Console.WriteLine("This program was bulit by Juan Jose Figueroa");
Console.WriteLine("--------------------------------------");
Console.WriteLine();

PersonModel person = new PersonModel();

person.FirstName = "What is your name: ?".RequestString();
person.LastName = "What is your last name: ?".RequestString();
person.Count = "What is your numeber count: ?".RequestString();

person.Amount = "What is your amount: ?".RequestDecimal(0,20);


Console.WriteLine($"Hello! { person.FirstName } { person.LastName }");
Console.WriteLine($"Count: { person.Count }");

Console.ReadLine();