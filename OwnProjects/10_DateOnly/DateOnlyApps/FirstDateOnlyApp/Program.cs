

Console.WriteLine("DateOnly");
var theDate = new DateOnly(2015, 10, 21);

var nextDay = theDate.AddDays(1);
var previousDay = theDate.AddDays(-1);
var decadeLater = theDate.AddYears(10);
var lastMonth = theDate.AddMonths(-1);



Console.WriteLine($"Date: {theDate}");
Console.WriteLine($" Next day: {nextDay}");
Console.WriteLine($" Previous day: {previousDay}");
Console.WriteLine($" Decade later: {decadeLater}");
Console.WriteLine($" Last month: {lastMonth}");
