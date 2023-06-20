


// int => double, decimal

int age = 12;

// double ageToDouble = (double) age;
double ageToDouble = Convert.ToDouble(age);

Console.WriteLine($"My age in double is {ageToDouble}");

decimal ageToDecimal = (decimal) age;


Console.WriteLine($"My age in decimal is {ageToDecimal}");


string ageToString = "14";

int ageconvert = int.Parse(ageToString);

// Try Parse


bool isAgeDecimal = decimal.TryParse("hola",out decimal ageDecimal);

if (isAgeDecimal)
{
    Console.WriteLine($"Yes: {ageDecimal}");
}


var DateString = "2022-05-09";

var Date = DateTime.Parse(DateString);

Console.WriteLine(Date.AddYears(1));



decimal area = 13.654M;

int areaInt = (int) area;

double areaToDouble = Convert.ToDouble(area);
Console.WriteLine(areaInt);
Console.WriteLine(areaToDouble);