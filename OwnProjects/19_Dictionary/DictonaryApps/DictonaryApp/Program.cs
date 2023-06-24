

using System.Collections.Generic;

var Dictionary = new Dictionary<string, string> 
{ 
    { "Juan", "Figueroa" },
    { "Jose", "Navarro" },
};

foreach (var name in Dictionary)
{
    Console.WriteLine(name.Key);
}

var domains = new Dictionary<string, string>
{
    {"sk", "Slovakia"},
    {"ru", "Russia"},
    {"de", "Germany"},
    {"no", "Norway"}
};

string domain = "ru";
var keyDictionary = domains.ContainsKey(domain) ? domains[domain] : $"{domain} doesn't in Dictionary";

Console.WriteLine(domains["no"]);
Console.WriteLine(keyDictionary);


var days = new Dictionary<string, string>
{
    ["mo"] = "Monday",
    ["tu"] = "Tuesday",
    ["we"] = "Wednesday",
    ["th"] = "Thursday",
    ["fr"] = "Friday",
    ["sa"] = "Saturday",
    ["su"] = "Sunday"
};
Console.WriteLine("-------------------");
Console.WriteLine("Days of the week");
foreach (var day in days)
{
    Console.WriteLine(day.Value);
}

Console.WriteLine($"There are {days.Count} items in the dictionary");

// Add items
days.Add("go", "Godday");

Console.WriteLine(string.Join(',',days.Values));

days.Remove("su");
Console.WriteLine(string.Join(',', days.Values));

days["ho"] = "holyday";

Console.WriteLine(string.Join(',', days.Values));

//days.Clear();
//Console.WriteLine("The users dictionary is empty",days.Count);
