

Console.WriteLine("This application calculate what day of the week is 40 days from now");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();


var DayOfWeek = new DateTime(2016, 8, 20, 16,18,17);

var addDays = DayOfWeek.AddDays(40);

Console.WriteLine($"{DayOfWeek:MM/dd/yyyy hh:mm:ss tt}");
Console.WriteLine($"The day in 40 days will be {addDays.DayOfWeek}.");