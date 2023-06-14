

Console.WriteLine("This is a program to determine truth tables for operations such as: \n- AND \n- OR \n- NOT \n- XOR.");
Console.WriteLine("This application was made by Juan Jose Figueroa.");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();

bool firstInput = true;
bool secondInput = false;

Console.WriteLine(@"  Truth tables");
Console.WriteLine(@"  1.Table for Negation");
Console.WriteLine($@"    P: {firstInput}");
Console.WriteLine($@"   ¬P: {!firstInput}");
Console.WriteLine();
Console.WriteLine(@"  2.Table for OR");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@"    P   |   Q   | Q or P");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {firstInput}  | {firstInput || firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {secondInput} | {firstInput || secondInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {firstInput}  | {secondInput || firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {secondInput} | {secondInput || secondInput}");
Console.WriteLine();
Console.WriteLine(@"  2.Table for AND");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@"    P   |   Q   | Q and P");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {firstInput}  | {firstInput && firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {secondInput} | {firstInput && secondInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {firstInput}  | {secondInput && firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {secondInput} | {secondInput && secondInput}");
Console.WriteLine();
Console.WriteLine(@"  3.Table for XOR");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@"    P   |   Q   | XOR ");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {firstInput}  | {!firstInput || !firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {firstInput}  | {secondInput} | {!firstInput || !secondInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {firstInput}  | {!secondInput || !firstInput}");
Console.WriteLine(@"  -----------------------");
Console.WriteLine(@$"  {secondInput} | {secondInput} | {secondInput || secondInput}");


