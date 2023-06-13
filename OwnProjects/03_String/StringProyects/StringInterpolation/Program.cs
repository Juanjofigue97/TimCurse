Console.WriteLine("This is a program that will demonstrate how strings Interpolation work in C#.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

string? firstName = "Juan";

Console.WriteLine($"My name is {firstName}");

Console.WriteLine($"If you want to use {{ }} in string interpolation, you need to:  {{{{ }}}} all together");

Console.WriteLine($"\'My name is {firstName}\' \n I am practicing special characters like \\n for a new line \n Or \\\" for a double quote \" \n Or \\t \t for a Horizontal tab");

Console.WriteLine($"If you want to use {{ }} in string interpolation, you need to:  {{{{ }}}} all together");

Console.WriteLine($"Hello, {firstName}! Today is {DateTime.Now:dd-MM-yyyy}, it's {DateTime.Now:HH:mm}");

Console.WriteLine($"|{"Left",-20}|{"Right",7}|");
