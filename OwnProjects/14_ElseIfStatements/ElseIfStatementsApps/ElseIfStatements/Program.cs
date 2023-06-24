


Console.WriteLine("In this program, I will test 'if' and 'else if' statements.");
Console.WriteLine("This program was built by Juan Jose Figueroa");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();

bool isValid = false;
int age = 0;
while (!isValid)
{
    Console.Write("Check if the person is of legal age: ");
    isValid = int.TryParse(Console.ReadLine(), out age);
}

if (age == 0)
{
    Console.WriteLine("You are not even one year old!");
}
else if (age > 0 && age < 10)
{
    Console.WriteLine("You are less than a decade old!");
}
else if (age >= 10 && age < 17)
{
    Console.WriteLine($"You need {18 - age} more years to reach the legal age!");
}
else if (age >= 18)
{
    Console.WriteLine("You are of legal age!");
}
else
{
    Console.WriteLine("You did not enter a valid age.");
}

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Thank you for using my program. See you next time!");
Console.ReadLine();
