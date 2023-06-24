


var names = new List<string>();

// List add elements

names.Add("Juan");
names.Add("Camilo");
names.Add("Andres");
names.Add("Frank");

Console.WriteLine($"This list has {names.Count} Names");
Console.WriteLine($"First name list: {names.First()}");

names.Sort();

Console.WriteLine(string.Join(",", names));

names.Reverse();

Console.WriteLine(string.Join(",", names));

foreach (string name in names)
{
    Console.WriteLine($"{name}");
}

// List Access Elements
Console.WriteLine($"{names[0]}");

Console.WriteLine(names[^2]);

// Inser elements 

names.Insert(1, "Marcela");
names.Insert(names.Count, "Tobby");

Console.WriteLine(string.Join(",", names));

// Cointains

Console.WriteLine(names.Contains("Juans"));
