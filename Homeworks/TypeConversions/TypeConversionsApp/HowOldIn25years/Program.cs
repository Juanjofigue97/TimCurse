Console.WriteLine("This application will tell you how old you will be in 25 years and how young you were 25 years ago");
Console.WriteLine("This program is built by Juan Jose Figuera.");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine();

Console.Write("Hello, how old are you?: ");
bool isValid = int.TryParse(Console.ReadLine(),out int age);

if (!isValid)
{
    Console.WriteLine("Warning! The age you enter must be in numbers.");
}
else
{
    Console.WriteLine($"- In 25 years, you will be [{age + 25}] years old");
    Console.WriteLine($"- 25 years ago, you were [{age - 25}] years old");
}
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for using my program. \nSee you soon!");
Console.WriteLine();
Console.ReadLine();