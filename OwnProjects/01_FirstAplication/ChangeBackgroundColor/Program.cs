// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.BackgroundColor = ConsoleColor.Green;

Console.WriteLine("Changing the console to green color");
Console.ReadLine();

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Changing the console to red color");
Console.ReadLine();

Console.WriteLine("Press enter to change the console to default color.");
Console.ReadLine();
Console.ResetColor();
