

using System.Globalization;

Console.WriteLine("This application will demonstrate the different ways of writing a date");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

DateTime today = DateTime.Now;

Console.WriteLine(today.ToString("f"));
Console.WriteLine(today.ToString("g"));
Console.WriteLine($"Using g: {today:g}");
Console.WriteLine($"Using G: {today:G}");
Console.WriteLine($"Using zzz: {today:zzz}");
Console.WriteLine($"Using dd/MM/yyyy - HH:mm: {today:dd/MM/yyyy - HH:mm}");

DateTime birthday = DateTime.Parse("04/02/1997");

DateTime holyDay = DateTime.ParseExact("8/8/2020", "d/M/yyyy",CultureInfo.InvariantCulture);

Console.WriteLine($"Birthday: {(birthday.ToString("d"))}");
Console.WriteLine($"HolyDay: {holyDay}");

