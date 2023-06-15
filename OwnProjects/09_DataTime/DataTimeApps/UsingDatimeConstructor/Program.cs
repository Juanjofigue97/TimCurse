

Console.WriteLine("This application will demonstrate the different ways of writing a date with a Constructor");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

DateTime FullDate = new DateTime(2016, 8, 6, 11, 49, 00);
DateTime ShortDate = new DateTime(2016, 8, 6);

Console.WriteLine($"Complete date: {FullDate}");
Console.WriteLine($"Short date: {ShortDate:d}");
//Console.WriteLine($"Short date: {FullDate.ToShortDateString()}");
Console.WriteLine($"Display date using 24-hour clock format:");
Console.WriteLine($"Complete date 24: {FullDate:dd/MM/yyyy HH:mm:ss}");
Console.WriteLine($"Complete date 24: {FullDate:g}");
Console.WriteLine($"Short date 24: {ShortDate:dd/MM/yyyy HH:mm}");