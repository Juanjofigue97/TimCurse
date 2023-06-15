

Console.WriteLine("This application is to greet all the students and professors who use it until you want to exit the program.");
Console.WriteLine("This application was built by Juan Jose Figueroa.");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
bool isExit =  true;
do
{
    Console.Write("What is your name: ");
    string firstName = Console.ReadLine();
    if (firstName.ToUpper() == "TIM")
    {
        Console.WriteLine($"Welcome Professor {firstName}");
    }
    else
    {
        Console.WriteLine($"Welcome Student {firstName}");
    }
    Console.WriteLine("Do you want to exit the application? Type 'exit' to exit.");
    string exit = Console.ReadLine();
    if (exit.ToUpper() == "EXIT")
    {
        isExit = false;
    }
} while (isExit);

Console.WriteLine("--------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for using this program, greetings");