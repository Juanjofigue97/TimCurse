


Console.WriteLine("In this program, we will calculate the triangle Area.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Please use commas to enter decimals. For example: 12,3 cm");
Console.Write("Enter a Base (cm): ");
double triangleBase = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a height (cm): ");
double triangleHeight = Convert.ToDouble(Console.ReadLine());

double triangleArea = triangleBase * triangleHeight /2;
Console.WriteLine("The area of the triangle is: {0}cm",triangleArea);

Console.ReadLine();

