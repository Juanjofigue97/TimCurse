

Console.WriteLine("This program I'm going to Practice Debbug");

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int totalSum = 0;


for (int i = 0; i < 10; i++)
{
    totalSum += 5 * number;
}

Console.WriteLine($"The total sum is { totalSum }");

Console.WriteLine("The program end.");
Console.ReadLine();