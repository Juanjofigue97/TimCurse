// "In this application, I will test what I have learned about integers."

int defaultInt = default;

Console.WriteLine($"The default value of an integer is: {defaultInt}");

int number1 = 2;
int number2 = 3;
int number3 = 2;

Console.WriteLine();
Console.WriteLine("The sum of the two values {0} + {1} is: {2}", number1, number2, number2 + number1);
Console.WriteLine();

Console.WriteLine("If you compare two integers using the compareTo function, it returns -1 for values that are not equal and 0 for equal values.");

Console.WriteLine($"For example: {number1} and {number2} : {number1.CompareTo(number2)}");
Console.WriteLine($"For example: {number1} and {number3} : {number1.CompareTo(number3)}");
Console.WriteLine();


uint UnsigedNumber = 9;

Console.WriteLine($"An unsigned integer only accepts values from zero to 2 to the power of 32. \nFor example: {UnsigedNumber}");
