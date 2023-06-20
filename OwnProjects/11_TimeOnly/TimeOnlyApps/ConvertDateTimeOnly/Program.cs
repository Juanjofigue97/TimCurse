


// Exercise: https://learn.microsoft.com/en-us/dotnet/standard/datetime/how-to-use-dateonly-timeonly
// Convert DateTime to TimeOnly

var now = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine($"It is {now} right now");

var birthday = new DateTime(1997, 2, 4, 10, 5, 3);

var birthhour = TimeOnly.FromDateTime(birthday);

Console.WriteLine($"The time of birth is {birthhour}");