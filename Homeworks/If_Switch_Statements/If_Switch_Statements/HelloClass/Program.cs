

Console.WriteLine("This application will greet you according to your name.");
Console.WriteLine("This program is built by Juan Jose Figueroa.");

Console.WriteLine("-------------------------------------------");

Console.WriteLine("Welcome to the C# classes!");
Console.Write("What's your name: ");

string userName = Console.ReadLine();

if (userName.ToLower() == "tim" || userName.ToLower() == "timothy")
{
    Console.WriteLine("Welcome Professor, how are you!");
}
else
{
    Console.WriteLine("Hello student, how is your day going?");
}
Console.WriteLine();
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Thank you for using my application. See you soon!");
Console.WriteLine();
Console.ReadLine();