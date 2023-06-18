

Console.WriteLine("This application will give you the name of a person located in a list of 3 names.");
Console.WriteLine("This application was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
// Create an array of 3 names

string[] names = new string[] { "Juan", "Jose", "Marcela" };

bool isValid = default;
int indexNumber = default;
do
{
    Console.Write("Please enter a number from 1 to 3: ");
    // Ask the user which number to Select
    isValid = int.TryParse(Console.ReadLine(), out indexNumber);
    if (!isValid || indexNumber <= 0 || indexNumber > 3)
    {
        isValid = false;
        Console.WriteLine("Please enter a valid number from 1 to 3 in characters. For example: 2.");
    }

} while (!isValid);

// Return a Name

Console.WriteLine($"The name at position {indexNumber} is {names[indexNumber - 1]}");
Console.WriteLine("-------------------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for using my application. Until next time!");
