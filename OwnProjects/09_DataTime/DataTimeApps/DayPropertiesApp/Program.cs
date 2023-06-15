Console.WriteLine("This application displays the Day properties (year, month, day, hour, minute, second, millisecond etc.)");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

var DayProperties = new DateTime(2016, 8, 16, 3, 57, 32, 11);

Console.WriteLine($"year = {DayProperties.Year}");
Console.WriteLine($"month = {DayProperties.Month}");
Console.WriteLine($"day = {DayProperties.Day}");
Console.WriteLine($"hour = {DayProperties.Hour}");
Console.WriteLine($"minute = {DayProperties.Minute}");
Console.WriteLine($"second = {DayProperties.Second}");
Console.WriteLine($"millisecond = {DayProperties.Millisecond}");