

Console.WriteLine("This program will greet all the guests at the party.");
Console.WriteLine("This program was built by Juan Jose Figueroa");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();
Console.Write("Please enter the names of all the people at the party: ");
string names = Console.ReadLine();


var ArrayNames = names.Split(',');


for (int i = 0; i < ArrayNames.Length; i++)
{
    Console.WriteLine($"Hello {ArrayNames[i]}! Thank you for coming.");
}

Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Thank you for using my program. See you next time!");