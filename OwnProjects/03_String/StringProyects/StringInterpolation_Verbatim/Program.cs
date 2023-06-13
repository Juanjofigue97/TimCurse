Console.WriteLine("This is a program that will use string interpolation along with verbatim.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

string firstName  = "Juan";
string lastName = "Figueroa";
string areaName = "Sistemas";
string companyName = "Cofinal";

string filepath = $@"D:{companyName}\{areaName}\{lastName}_{firstName}.pdf";

Console.WriteLine($"Your file is located at the following path: {filepath}");