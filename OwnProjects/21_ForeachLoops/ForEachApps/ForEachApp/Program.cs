

int[] vals = { 1, 2, 3, 4, 5 };

foreach (var val in vals)
{
    Console.WriteLine(val);
}

var words = new List<string> { "tea", "falcon", "book", "sky" };

words.ForEach(x => Console.WriteLine(x));

foreach (var word in words)
{
    Console.WriteLine(word);
}

var wordsLists = new List<List<string>>
{
    new List<string>{"tea", "falcon", "book", "sky"},
    new List<string>{"cup", "crown", "borrow", "moore"},
    new List<string>{"arm", "nice", "frost", "sea"}
};

foreach (var nested in wordsLists)
{
    Console.WriteLine(nested.FirstOrDefault());
    foreach (var word in nested)
    {
        Console.WriteLine(word);
    }
}


var domains = new Dictionary<string, string>
{
    {"sk", "Slovakia"},
    {"ru", "Russia"},
    {"de", "Germany"},
    {"no", "Norway"}
};

foreach (var pair in domains)
{
    Console.WriteLine($"{pair.Key} - {pair.Value}");
}

Console.WriteLine("-----------------------");

foreach ((var Key, var Value) in domains)
{
    Console.WriteLine($"{Key} - {Value}");
}

int[] numbers = { 1, 2, 3, 4, 5 };
Array.ForEach(numbers, e => Console.WriteLine(e));

domains.ToList().ForEach(e => Console.WriteLine(e.Value));