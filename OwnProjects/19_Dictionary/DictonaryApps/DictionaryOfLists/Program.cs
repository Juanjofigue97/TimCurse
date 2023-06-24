


var data = new Dictionary<int, List<int>>
{
    [1] = new List<int> { 1, 1, 1, 1, 1 },
    [2] = new List<int> { 3, 3, 3, 3, 3 },
    [3] = new List<int> { 5, 5, 5, 5, 5 },
};

int TotalSum = 0;

foreach (var (key, e) in data)
{
    var _sum = e.Sum();
    TotalSum += _sum;
    Console.WriteLine($"The sum of nested list is: {_sum}");
}
Console.WriteLine($"The total sum is: {TotalSum}");