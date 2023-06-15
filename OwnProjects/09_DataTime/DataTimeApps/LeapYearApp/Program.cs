

Console.WriteLine("This application displays the Leap Years");
Console.WriteLine("This program is built by Juan Jose Figueroa");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();


Console.WriteLine("My Solution: ");
for (int i = 1; i < 9; i++)
{
    int year = 2000 + i;
    DateTime Date = new DateTime(year, 12, 31);
    Console.WriteLine("{0:MM/dd/yyyy}: day {1} of {2} {3}",
                        Date,
                        Date.DayOfYear,
                        Date.Year,
                        (Date.DayOfYear == 366) ? "(Leap Year)" : "");
}
Console.WriteLine("Problem Solution: ");
DateTime dec31 = new DateTime(2000, 12, 31);
for (int ctr = 0; ctr <= 20; ctr++)
{
    DateTime dateToDisplay = dec31.AddYears(ctr);
    Console.WriteLine("{0:MM/dd/yyyy}: day {1} of {2} {3}", dateToDisplay,
                      dateToDisplay.DayOfYear,
                      dateToDisplay.Year,
                      DateTime.IsLeapYear(dateToDisplay.Year) ?
                                          "(Leap Year)" : "");
}