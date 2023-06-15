

Console.WriteLine("This application get the day of the week for a specified date");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();


var DayOfWeek = new DateTime(2016,11,7);

Console.WriteLine($"The day of the week for {DayOfWeek:d/MM/yyyy} is {DayOfWeek.DayOfWeek}.");