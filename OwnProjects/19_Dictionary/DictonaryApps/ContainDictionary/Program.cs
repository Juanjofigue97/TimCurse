var domains = new Dictionary<string, string>
{
    {"sk", "Slovakia"},
    {"ru", "Russia"},
    {"de", "Germany"},
    {"no", "Norway"}
};

var key = "co";

if (domains.ContainsKey(key))
{
    Console.WriteLine($"The {key} key is in the dictionary");
}
else
{
    Console.WriteLine($"The {key} key is in not the dictionary");
}

var value = "Slovakia";

if (domains.ContainsValue(value))
{
    Console.WriteLine($"The {value} value is in the dictionary");
}
else
{
    Console.WriteLine($"The {value} value is in not the dictionary");
}

foreach(var (keys,values) in domains)
{
    Console.WriteLine($"{keys}: {values}");
}

foreach (var name in domains.Values)
{
    Console.WriteLine(name);
}
