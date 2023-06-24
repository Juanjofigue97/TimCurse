

var names = new List<string> {"John Doe", "Lucy Smith",
        "Benjamin Young", "Robert Brown", "Thomas Moore",
        "Linda Black", "Adam Smith", "Jane Smith"};

names.Sort((n1, n2) => n1.Split(" ")[1].CompareTo(n2.Split(" ")[1]));
Console.WriteLine(string.Join(",", names));

foreach (var name in names)
{
    Console.WriteLine(name);
}

// Using Linq
Console.WriteLine();
Console.WriteLine("Using LINQ");
Console.WriteLine();
var res = from name in names
          orderby name.Split(" ")[1]
          ascending
          select name;

foreach (var name in res)
{
    Console.WriteLine(name);
}