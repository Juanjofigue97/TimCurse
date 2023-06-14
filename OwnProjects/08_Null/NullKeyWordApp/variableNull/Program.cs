

Console.WriteLine("In this application, we will interact with the reserved word 'null'.");
Console.WriteLine("This program is built by Juan Jose Figueroa.");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine();

int? number = null;

Console.WriteLine(number.HasValue ? number.Value.ToString() : "This variable is null");
Console.WriteLine(number?.ToString());

double? averageWeight = null;

decimal? totalWeightEarth = null;

string? fullname = null;
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine(averageWeight);
Console.WriteLine(totalWeightEarth);
Console.WriteLine(fullname);