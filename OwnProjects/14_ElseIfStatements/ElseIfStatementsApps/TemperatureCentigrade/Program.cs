


Console.WriteLine("In this program, The user give a temperature in centigrade and display a suitable message according to the temperature state below.");
Console.WriteLine("This program was built by Juan Jose Figueroa");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();

Console.Write("Please enter the temperature in Celsius degrees: ");

int Celsius = int.Parse(Console.ReadLine());

if (Celsius < 0)
{
    Console.WriteLine("Freezing weather");
}
else if (Celsius >= 0 && Celsius < 10)
{
    Console.WriteLine("Very Cold weather");
}
else if (Celsius >= 10 && Celsius < 20)
{
    Console.WriteLine("Cold weather");
}
else if (Celsius >= 20 && Celsius < 30)
{
    Console.WriteLine("Normal in Temp");
}else if (Celsius >= 30 && Celsius < 40)
{
    Console.WriteLine("Its Hot");
}else if(Celsius >= 40)
{
    Console.WriteLine("Its Very Hot");
}
else
{
    Console.WriteLine("You did not enter a valid Temperature.");
}
