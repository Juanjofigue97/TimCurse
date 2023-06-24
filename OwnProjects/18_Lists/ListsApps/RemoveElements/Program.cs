

var nums = new List<int> { 0, 1, 2, -3, 4, -5, 6, 7, -8, 9, 10 };

nums.RemoveAll(e => e < 0);
Console.WriteLine(string.Join(", ", nums));

nums.Remove(0);
nums.RemoveAt(nums.Count - 1);

Console.WriteLine(string.Join(", ", nums));

nums.RemoveRange(0, 3);

Console.WriteLine(string.Join(", ", nums));

nums.Clear();
Console.WriteLine("{0}", nums.Count);

var Names = new List<string> {"John Doe", "Lucy Smith",
        "Benjamin Young", "Robert Brown", "Thomas Moore",
        "Linda Black", "Adam Smith", "Jane Smith"};

Console.WriteLine(Names.Remove("Jose")); 
Console.WriteLine(Names.Remove("Robert Brown"));
Console.WriteLine($"The number of removed elements: {Names.RemoveAll(name => name.Split(" ")[1] == "Smith")}");

//Console.WriteLine(Names.RemoveAll(word => word.Length > 10));
foreach (var name in Names)
{
    Console.WriteLine(name);
}


