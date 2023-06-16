

static bool IsLeapYear(int year)
{
    bool divi4 = year % 4 == 0;
    bool divi100 = year % 100 == 0;
    bool divi400 = year % 400 == 0;
    if (divi4)
    {
        if (divi100)
        {
            if (divi400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    else
    {
        return false;
    }
}

bool isYear = int.TryParse(Console.ReadLine(), out int year);

Console.WriteLine($"This year is leap {year} : {IsLeapYear(year)}");