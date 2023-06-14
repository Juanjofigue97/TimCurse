

Console.WriteLine("In this program, we will calculate the Quadratic formula.");
Console.WriteLine("This program was built by Juan Jose Figueroa.");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

Console.WriteLine("x = -b ± √b^2 - 4*a*c");
Console.WriteLine(@"   ------------------");
Console.WriteLine("\t  2*a");
Console.WriteLine("Please enter the parameters: ");

Console.Write("Parameter a: ");
double parameterA = Convert.ToDouble(Console.ReadLine());
Console.Write("Parameter b: ");
double parameterB = Convert.ToDouble(Console.ReadLine());
Console.Write("Parameter c: ");
double parameterC = Convert.ToDouble(Console.ReadLine());

double Discriminant = (Math.Pow(parameterB, 2) - 4 * parameterA * parameterC);

if( Discriminant > 0)
{
    Console.WriteLine("There are two real and distinct solutions.");
    double firstSolution = (- parameterB - Math.Sqrt(Discriminant)) / (2*parameterA);
    double SecondSolution = (-parameterB + Math.Sqrt(Discriminant)) / (2 * parameterA);
    Console.WriteLine($"X_1 = {firstSolution:0.###}");
    Console.WriteLine($"X_2 = {SecondSolution:0.###}");
}
else if (Discriminant == 0)
{
    Console.WriteLine("There is a single real solution.");
    double firstSolution = (-parameterB - Math.Sqrt(Discriminant)) / (2 * parameterA);
    Console.WriteLine($"X = {firstSolution:0.###}");
}
else
{
    Discriminant *= -1;  
    Console.WriteLine("There are two distinct complex solutions.");
    double firstEquation = (-parameterB) / (2 * parameterA);
    double SecondEquation = (Math.Sqrt(Discriminant)) / (2 * parameterA);
    Console.WriteLine($"X_1 = {firstEquation:0.###} + {SecondEquation:0.###}i");
    Console.WriteLine($"X_2 = {firstEquation:0.###} - {SecondEquation:0.###}i");
}

Console.ReadLine();
