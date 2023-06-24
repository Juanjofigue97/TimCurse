


var words = new List<string> {"falcon", "order", "war",
        "sky", "ocean", "blue", "cloud", "boy", "by", "raven",
        "station", "batallion"};

words.Sort((a, b) => a.Length.CompareTo(b.Length));

Console.WriteLine(string.Join(",", words));

Console.WriteLine();

// Using LINQ
var res = from word in words
          orderby word.Length
          ascending
          select word;

Console.WriteLine(string.Join(",", res));
