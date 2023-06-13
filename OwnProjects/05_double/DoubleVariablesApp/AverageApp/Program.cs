

Console.WriteLine("In this program, we will calculate the average of a list of data.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();
bool continuation = true;
string allNumbers = "";
int Counter = 0;
double totalSum = 0.0;
while (continuation)
{
    try
    {
        Counter += 1;

        Console.Write("Enter a number:");
        string? number = Console.ReadLine();
        allNumbers += $"{number}";

        totalSum += Convert.ToDouble(number);
        
        Console.WriteLine("Do you want to enter another number? (y/n)");
        string? Validation = Console.ReadLine();
        if (Validation?.ToUpper() != "Y")
        {
            continuation = false;
            break;
        }
        allNumbers += ",";
    }
    catch
    {

    }
}

Console.WriteLine($"The average of your list of numbers [{allNumbers}] is:{totalSum/Counter}");