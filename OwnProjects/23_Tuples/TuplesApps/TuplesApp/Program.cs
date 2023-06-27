



using TuplesApp;

Console.Write("Enter a first number: ");

bool isDobleX,isDobleY; 
double x;
isDobleX = double.TryParse(Console.ReadLine(),out x);

Console.Write("Enter a Second number: ");
double y;
isDobleY = double.TryParse(Console.ReadLine(), out y);

if (isDobleX && isDobleY)
{
    var (resultAdd,resultSub) = MathShortcuts.BasicOperation(x,y);

    Console.WriteLine($"The result to add { x } + { y } is { resultAdd }");
    Console.WriteLine($"The result to sub { x } - { y } is {resultSub}");
}

// Simple Example

var u1 = Tuple.Create("John", "Done", "gardener");
Console.WriteLine($"{u1.Item1} {u1.Item2} is a {u1.Item3}");

var u2 = ("Roger", "Roe", "driver");
Console.WriteLine($"{u2.Item1} {u2.Item2} is a {u2.Item3}");

// Tuple fiel names

var person = (Name: "John Doe", Age: 34);
Console.WriteLine($"{person.Name} is {person.Age} years old");

(string Name, int Age) personTwo = ("Roger Roe", 55);
Console.WriteLine($"{personTwo.Name}  is  {personTwo.Age} years old");

var name = "Jane Doe";
var age = 26;

var person3 = (name, age);
Console.WriteLine($"{person3.name} is {person3.age} years old");