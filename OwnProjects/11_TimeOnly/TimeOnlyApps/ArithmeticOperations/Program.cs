


var start = new TimeOnly(8, 0);
var end = new TimeOnly(12, 0);

// Add hours

Console.WriteLine($"The start time is {start}");
Console.WriteLine($"The start time is {start.AddHours(1)} Add 1 Hour");
Console.WriteLine($"The start time is {start.AddMinutes(65)} Add 61 minutes");

if ( start < end)
{
    Console.WriteLine($"{start} is before {end}");
}

start = start.Add(new TimeSpan( 8, 3,2));

if (start > end)
{
    Console.WriteLine($"{start} is after {end}");
}

// The number represent 10 It represents the total number of ticks
Console.WriteLine(TimeOnly.MinValue.Ticks);
Console.WriteLine(TimeOnly.MaxValue.Ticks);

