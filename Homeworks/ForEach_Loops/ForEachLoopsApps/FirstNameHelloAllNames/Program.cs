


Console.WriteLine("This program will greet all the Users.");
Console.WriteLine("This program was built by Juan Jose Figueroa");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();


List<string> names = new();
bool isFinish = false;
while (!isFinish)
{
    Console.Write("Please enter the name of user: ");
    string name = Console.ReadLine();
    names.Add(name);

    Console.Write("Would you like to continue entering names? y/n: ");
    string valid = Console.ReadLine();

    isFinish = valid.ToUpper() == "Y" ? false:true;
}
Console.WriteLine();
Console.WriteLine("---------------------------------------------");
foreach (var item in names)
{
    Console.WriteLine($"Hello {item} Thank you for coming");
}


Console.WriteLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Thank you for using my program. See you next time!");