

var vals = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

vals.Shuffle();

var res = string.Join(" ", vals);
Console.WriteLine(res);

static class MyExtensions
{
    private static Random rng = new Random();

    public static void Shuffle<T>(this IList<T> vals)
    {
        int n = vals.Count;

        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);

            T value = vals[k];

            vals[k] = vals[n];
            vals[n] = value;
        }
    }
}

