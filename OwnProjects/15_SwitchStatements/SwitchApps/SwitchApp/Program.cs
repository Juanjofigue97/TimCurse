


Console.WriteLine("Create a C# ");

int number = 9;

switch (number)
{
    case 0 or 1 or 2 or 3 or 4:
        Console.WriteLine($"Fail");
        break;
    case 5:
        Console.WriteLine($"Pass");
        break;
    case 6:
        Console.WriteLine($"Good");
        break;
    case 7 or 8:
        Console.WriteLine($"Excellent");
        break;
    case 9 or 10:
        Console.WriteLine($"Outstanding");
        break;
}

// Simply Swtich case

var Menssage = number switch
{
    9 or 10 => "Outstanding",
    7 or 8 => "Excellent",
    6 => "Good",
    5 => "Pass",
    _ => "Fail"
};
Console.WriteLine(Menssage);