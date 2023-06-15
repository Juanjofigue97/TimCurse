

using System.Globalization;

DateOnly dateOnly = DateOnly.Parse("11-13-2012",CultureInfo.InvariantCulture);

Console.WriteLine(dateOnly);

CultureInfo Colombia = new CultureInfo("es-CO");

DateOnly Date2 = DateOnly.ParseExact("19-08-29","yy-MM-dd", Colombia);

Console.WriteLine($"{Date2.DayOfWeek}");

CultureInfo enUs = new CultureInfo("es-CO");

foreach (string dayName in enUs.DateTimeFormat.DayNames)
    Console.WriteLine(dayName);
Console.WriteLine("Today is: " + enUs.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));