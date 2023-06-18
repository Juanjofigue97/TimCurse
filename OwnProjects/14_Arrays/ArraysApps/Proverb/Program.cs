using Proverb;

var strings = new[] {"nail","shoe"};


foreach (var line in Proverb.Proverb.Recite(strings))
{
    Console.WriteLine(line);
}