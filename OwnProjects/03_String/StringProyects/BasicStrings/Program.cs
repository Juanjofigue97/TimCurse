Console.WriteLine("This is a program that will demonstrate how strings work in C#.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Juan";
lastName = "Figueroa";
filePath = "E:Chapter1\\names.txt";

// Using String interpolation 
Console.WriteLine("Using String Interpolation: ");
Console.WriteLine($"My name is {firstName} and my last name is {lastName}");
Console.WriteLine();

// Using Verbatim String Literal
Console.WriteLine("Verbatim String Literal: ");
Console.WriteLine(@"E:Chapter1\names.txt");
Console.WriteLine();

// Using Format String 
Console.WriteLine("Format String : ");
Console.WriteLine("My name is {0} and my last name is {1}",firstName,lastName);
//Console.WriteLine(String.Format("My first name is {0}, my last name is {1} and my documents are in {2}",firstName,lastName, filePath));

Console.WriteLine("My first name is {0}, my last name is {1} and my documents are in {2}",firstName,lastName, filePath);

Console.ReadLine();