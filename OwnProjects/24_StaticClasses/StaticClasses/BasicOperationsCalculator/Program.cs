

using BasicOperationsCalculator;

string firstName = RequestData.GetAStrig("What is your first name: ");

UserMessages.ApplicationStartMessage(firstName);

double x = RequestData.GetADouble("Please enter your first number: ");
double y = RequestData.GetADouble("Please enter your second number: ");

double resultAdd = CalculateData.Add(x, y);
UserMessages.PrintResultMessage($"The sum of { x } and { y } is { resultAdd }");

double resultSubtract = CalculateData.Subtract(x, y);
UserMessages.PrintResultMessage($"The subtract of { x } and { y } is { resultSubtract }");

double resultMultiply = CalculateData.Multiply(x, y);
UserMessages.PrintResultMessage($"The multiply of { x } and { y } is { resultMultiply }");

double resultDivide = CalculateData.Divide(x, y);
UserMessages.PrintResultMessage($"The divide of { x } and { y } is { resultDivide }");


Console.ReadLine();
