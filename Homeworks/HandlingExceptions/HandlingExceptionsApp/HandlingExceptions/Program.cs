


Console.WriteLine("We are Catch Exceptions");

List<int> listNumbers = new()
{
    1, 2, 3, 4, 5
};

try
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine($"The number is {listNumbers[i]}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"The expection was {ex.Message}");
}

